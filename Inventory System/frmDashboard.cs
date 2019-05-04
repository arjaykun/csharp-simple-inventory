using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class frmDashboard : Form
    {
        public static string username;
        public static string name;
        public static string user_type;

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void pnlItems_Click(object sender, EventArgs e)
        {
            ucItems uc = new ucItems();
            ChangeMenu(uc);
            indicator.Location = new System.Drawing.Point(7, pnlItems.Location.Y);
        }
        private void ChangeMenu(UserControl uc = null)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(uc);
            indicator.Location = new System.Drawing.Point(7, pnlItems.Location.Y);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            ucItems uc = new ucItems();
            ChangeMenu(uc);

            lblName.Text = name;
            lblUserType.Text = user_type.ToUpper();
            indicator.Location = new System.Drawing.Point(7, pnlItems.Location.Y);

            if (user_type != "admin")
            {
                panel4.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form1 frm = new Form1())
            {
                frm.ShowDialog();
            }
        }

        private void pnlStocks_Click(object sender, EventArgs e)
        {
            ucStocks uc = new ucStocks();
            ChangeMenu(uc);
            indicator.Location = new System.Drawing.Point(7, pnlStocks.Location.Y);
        }

        private void pnlOrders_Click(object sender, EventArgs e)
        {
            ucOrders uc = new ucOrders();
            ChangeMenu(uc); indicator.Location = new System.Drawing.Point(7, pnlOrders.Location.Y);
        }

        private void pnllogs_Click(object sender, EventArgs e)
        {
            ucLogs uc = new ucLogs();
            ChangeMenu(uc);
            indicator.Location = new System.Drawing.Point(7, pnllogs.Location.Y);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            ucUsers uc = new ucUsers();
            ChangeMenu(uc);
            indicator.Location = new System.Drawing.Point(7, panel4.Location.Y);
        }
    }
}
