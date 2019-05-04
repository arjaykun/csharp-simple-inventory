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
    public partial class frmChooseItem : Form
    {
        public delegate void DoEvent(items items);
        public event DoEvent add_item;
        private DataTable dt = new DataTable();

        public frmChooseItem()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChooseItem_Load(object sender, EventArgs e)
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

        private void metroTile2_Click(object sender, EventArgs e)
        {
            items i = new items()
            {
                item_id = int.Parse(lstItems.SelectedItems[0].Text),
                item_code = lstItems.SelectedItems[0].SubItems[1].Text,
                item_name = lstItems.SelectedItems[0].SubItems[2].Text,
                price = decimal.Parse(lstItems.SelectedItems[0].SubItems[3].Text.Substring(1)),
                stocks = int.Parse(lstItems.SelectedItems[0].SubItems[4].Text)
            };
            if (i.stocks <=0 )
            {
                MetroFramework.MetroMessageBox.Show(this, "Item is out of stock! Please re-stock first!", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            add_item(i);
            this.Hide();
        }
    }
}
