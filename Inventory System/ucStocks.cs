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
    public partial class ucStocks : UserControl
    {
        private DataTable dt = new DataTable();
        private int id = 0;
        public ucStocks()
        {
            InitializeComponent();
        }

        private void ucStocks_Load(object sender, EventArgs e)
        {
            load_items();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            load_items(search);
        }

        private void lstItems_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                txtCode.Text = lstItems.SelectedItems[0].SubItems[1].Text;
                txtName.Text = lstItems.SelectedItems[0].SubItems[2].Text;
                txtStocks.Text = lstItems.SelectedItems[0].SubItems[4].Text;
                id = int.Parse(lstItems.SelectedItems[0].Text);
                btnAdd.Enabled = true;
                txtAdd.Enabled = true;
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtAdd.Text == "")
            {
                return;
            }

            int stocks = int.Parse(txtStocks.Text);
            int new_stocks = int.Parse(txtAdd.Text);


            txtNew.Text = (stocks + new_stocks).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string stocks = txtNew.Text;
                if (stocks == "" || txtNew.Text == "")
                {
                    MetroMessageBox.Show(this, "Please input stocks to add to update the item's stocks.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string query = $"update items set stocks = '{stocks}' where item_id = '{id}'";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MetroMessageBox.Show(this, "New stocks is added successfully!", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_items();
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

        private void reset()
        {
            txtNew.Text = "";
            txtAdd.Text = "";
            txtCode.Text = "";
            txtName.Text = "";
            txtStocks.Text = "";
            btnAdd.Enabled = false;
            txtAdd.Enabled = false;
        }

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
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
    }
    
}
