using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Form1 : Form
    {
        private DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                string username = txtUsername.Text;
                string pwd = txtPassword.Text;
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    string query = $"select * from users where username = '{username}'";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        if (pwd == Convert.ToString(dt.Rows[0]["password"]))
                        {
                            using (frmDashboard frm = new frmDashboard())
                            {
                                frmDashboard.username = Convert.ToString(dt.Rows[0]["username"]);
                                frmDashboard.name = Convert.ToString(dt.Rows[0]["name"]);
                                frmDashboard.user_type = Convert.ToString(dt.Rows[0]["user_type"]);
                                this.Hide();
                                frm.ShowDialog();
                            }
                        }
                        else
                            MetroMessageBox.Show(this, "Invalid Username/ Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MetroMessageBox.Show(this, "Invalid Username/ Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !metroCheckBox1.Checked;
        }
    }
}
