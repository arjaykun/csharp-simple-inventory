using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using MetroFramework;

namespace Inventory_System
{
    public partial class ucItems : UserControl
    {
        private DataTable dt = new DataTable();
        private int id = 0;

        public ucItems()
        {
            InitializeComponent();
        }

        private void ucItems_Load(object sender, EventArgs e)
        {
            generate_code();
            load_total_item();
            load_items();
        }

        private void generate_code()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                dt.Clear();
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand("select max(item_id) from items", conn);
                int max = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                txtCode.Text = $"{DateTime.Today.Year}{max:00000}";

                cmd.Dispose();
            }
        }

        private void load_total_item()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                dt.Clear();
                string query = "select * from items";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
              
                lblTotalItem.Text = dt.Rows.Count.ToString();
            }
        }

        private void reset()
        {
            generate_code();
            load_total_item();
            load_items();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtName.Text = "";
            txtPrice.Text = "";
            txtStocks.Text = "";
        }

        private void load_items(string search = "")
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                dt.Clear();
                lstItems.Items.Clear();
                string query = $"select * from items where item_name like '%{search}%' or item_code like '%{search}%'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(row["item_id"]));
                    ListViewItem.ListViewSubItem[] subitems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, Convert.ToString(row["item_code"])),
                        new ListViewItem.ListViewSubItem(item, Convert.ToString(row["item_name"])),
                        new ListViewItem.ListViewSubItem(item, Convert.ToDecimal(row["price"]).ToString("c")),
                        new ListViewItem.ListViewSubItem(item, Convert.ToString(row["stocks"]))
                    };
                    item.SubItems.AddRange(subitems);
                    lstItems.Items.Add(item);

                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string code = txtCode.Text;
                string name = txtName.Text;
                string price = txtPrice.Text;
                string stocks = txtStocks.Text;
                if (code == "" || name == "" || price == "" || stocks == "")
                {
                    MetroMessageBox.Show(this, "Warning! Please fill-up all item details to continue.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    string query = "insert into items (item_code, item_name, price, stocks) values" + 
                        $"('{code}','{name}','{price}','{stocks}')";
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MetroMessageBox.Show(this, "New item is added successfully!", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstItems_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                txtCode.Text = lstItems.SelectedItems[0].SubItems[1].Text;
                txtName.Text = lstItems.SelectedItems[0].SubItems[2].Text;
                txtPrice.Text = lstItems.SelectedItems[0].SubItems[3].Text.Substring(1);
                txtStocks.Text = lstItems.SelectedItems[0].SubItems[4].Text;
                id = int.Parse(lstItems.SelectedItems[0].Text);
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string code = txtCode.Text;
                string name = txtName.Text;
                string price = txtPrice.Text;
                string stocks = txtStocks.Text;
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    string query = $"update items set item_name = '{name}', price = '{price}', stocks= '{stocks}' where item_id = '{id}'";
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MetroMessageBox.Show(this, "Item is updated successfully!", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    string query = $"delete from items where item_id = '{id}'";
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MetroMessageBox.Show(this, "Item is deleted successfully!", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            load_items(search);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
                e.Handled = true;

        }

        private void txtStocks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
                btnAdd.Focus();
            }
            else
                e.Handled = true;

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text.Contains("."))
            {
                return;
            }
        }
    }
}
