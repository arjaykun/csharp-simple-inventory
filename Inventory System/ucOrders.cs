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
    public partial class ucOrders : UserControl
    {
        private List<order_items> order = new List<order_items>();
        private items _item;
        private items itemObj = new items();
        public ucOrders()
        {
            InitializeComponent();
        }

        private void ucOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (frmChooseItem frm = new frmChooseItem())
            {
                frm.add_item += Frm_add_item;
                frm.ShowDialog();
            }
        }

        private void Frm_add_item(items items)
        {
            txtName.Text = items.item_name;
            txtCode.Text = items.item_code;
            txtQuantity.Text = "1";
            txtQuantity.Focus();
            _item = items;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_item.stocks < int.Parse(txtQuantity.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, $"Stocks in not enough! You only have {_item.stocks} items left.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (order_items item in order)
            {
                if (_item.item_id == item.item.item_id)
                {
                    order.Remove(item);
                    break;
                }
            }
            order.Add(new order_items()
            {
                item = _item,
                quantity = int.Parse(txtQuantity.Text)
            });

            load_list(order);
            txtCode.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
        }
        

        private void load_list(List<order_items> items)
        {
            lstSummary.Items.Clear();
            decimal total = 0;
            foreach (order_items i in items)
            {
                ListViewItem item = new ListViewItem(i.item.item_id.ToString());
                ListViewItem.ListViewSubItem[] subitems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, i.item.item_code),
                    new ListViewItem.ListViewSubItem(item, i.item.item_name),
                    new ListViewItem.ListViewSubItem(item, i.item.price.ToString("c")),
                    new ListViewItem.ListViewSubItem(item, i.quantity.ToString()),
                    new ListViewItem.ListViewSubItem(item, i.subtotal.ToString("c"))
                };

                item.SubItems.AddRange(subitems);
                lstSummary.Items.Add(item);
                total += i.subtotal;
            }
            lblTotal.Text = total.ToString("c");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (lstSummary.SelectedItems.Count > 0)
            {
                order.RemoveAt(lstSummary.SelectedIndices[0]);
                load_list(order);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            order.Clear();
            load_list(order);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (order.Count > 0)
            {
                string name = txtCustomerName.Text;
                string contacts = txtContactNumber.Text;
                string address = txtAddress.Text;
                string total = lblTotal.Text.Substring(1);
                if (name == "" || contacts == "" || address == "")
                {
                    MetroMessageBox.Show(this, "Warning! Please fill up all customer fields to continue.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                    {
                        conn.Open();
                        DateTime date = DateTime.Now;
                        string query = "insert into orders (customer_name, contacts, address, order_price, order_date) " +
                                $"values('{name}', '{contacts}','{address}','{total}', '{date}');";
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        int res = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        if (res > 0)
                        {
                            update_stocks();
                            using (frmReceipt frm = new frmReceipt(order, txtCustomerName.Text, date, lblTotal.Text, frmDashboard.name))
                            {
                                frm.ShowDialog();
                            }

                            order.Clear();
                            load_list(order);
                            txtCustomerName.Text = "";
                            txtContactNumber.Text = "";
                            txtAddress.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void update_stocks()
        {
            foreach (order_items item in order)
            {
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                    {
                        conn.Open();
                        int stocks = item.item.stocks;
                        string query = $"update items set stocks = {stocks - item.quantity} where item_id = '{item.item.item_id}'";
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.ExecuteNonQuery();

                        cmd.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
