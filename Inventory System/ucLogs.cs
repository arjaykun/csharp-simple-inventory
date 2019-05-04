using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SQLite;

namespace Inventory_System
{
    public partial class ucLogs : UserControl
    {
        private DataTable dt = new DataTable();
        public ucLogs()
        {
            InitializeComponent();
        }

        private void ucLogs_Load(object sender, EventArgs e)
        {
            load_logs();
            load_status();
        }

        private void load_status()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                dt.Clear();
                string query = "select * from orders";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
                decimal total_sales = 0;
                decimal monthly_sales = 0;
                int month = DateTime.Today.Month;
                foreach (DataRow row in dt.Rows)
                {
                    decimal sales = Convert.ToDecimal(row["order_price"]);
                    total_sales += sales;
                    if (month == Convert.ToDateTime(row["order_date"]).Month)
                    {
                        monthly_sales += sales;
                    }
                }
                lblMonthly.Text = monthly_sales.ToString("c");
                lblTotalSales.Text = total_sales.ToString("c");
                lblTotalOrders.Text = dt.Rows.Count.ToString();
            }
        }


        private void load_logs(string search = "")
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                dt.Clear();
                lstItems.Items.Clear();
                string query = $"select * from orders where customer_name like '%{search}%' or order_id like '%{search}%'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(row["order_id"]));
                    ListViewItem.ListViewSubItem[] subitems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, Convert.ToString(row["customer_name"])),
                        new ListViewItem.ListViewSubItem(item, Convert.ToString(row["contacts"])),
                        new ListViewItem.ListViewSubItem(item, Convert.ToDecimal(row["order_price"]).ToString("c")),
                        new ListViewItem.ListViewSubItem(item, Convert.ToDateTime(row["order_date"]).ToString()),
                        new ListViewItem.ListViewSubItem(item, Convert.ToString(row["address"]))
                    };
                    item.SubItems.AddRange(subitems);
                    lstItems.Items.Add(item);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            load_logs(txtSearch.Text);
        }
    }
}
