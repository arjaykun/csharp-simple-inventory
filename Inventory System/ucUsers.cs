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
    public partial class ucUsers : UserControl
    {
        private DataTable dt = new DataTable();
        private int id = 0;
        public ucUsers()
        {
            InitializeComponent();
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            load_users();
        }

        private void load_users()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                dt.Clear();
                lstItems.Items.Clear();
                string query = $"select * from users";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(row["user_id"]));
                    ListViewItem.ListViewSubItem[] subitems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, Convert.ToString(row["name"])),
                        new ListViewItem.ListViewSubItem(item, Convert.ToString(row["username"])),
                        new ListViewItem.ListViewSubItem(item, Convert.ToString(row["password"])),
                        new ListViewItem.ListViewSubItem(item, Convert.ToString(row["user_type"]))
                    };
                    item.SubItems.AddRange(subitems);
                    lstItems.Items.Add(item);
                }
            }
        }

        private void lstItems_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                txtName.Text = lstItems.SelectedItems[0].SubItems[1].Text;
                txtUsername.Text = lstItems.SelectedItems[0].SubItems[2].Text;
                txtPassword.Text = lstItems.SelectedItems[0].SubItems[3].Text;
                id = int.Parse(lstItems.SelectedItems[0].Text);
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if (name == "" || username == "" || password == "")
                {
                    MetroMessageBox.Show(this, "Warning! Please fill-up all item details to continue.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    string query = "insert into users (name, username, password, user_type) values" +
                        $"('{name}','{username}','{password}','stockman')";
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MetroMessageBox.Show(this, "New stockman is added successfully!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            load_users();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            txtName.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            id = 0;
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !metroCheckBox1.Checked;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    string query = $"delete from users where user_id = '{id}'";
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MetroMessageBox.Show(this, "User is deleted successfully!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if (name == "" || username == "" || password == "")
                {
                    MetroMessageBox.Show(this, "Warning! Please fill-up all item details to continue.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    string query = $"update users set name = '{name}', password = '{password}', username = '{username}' where user_id = '{id}'";
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MetroMessageBox.Show(this, "User is updated successfully!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
