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
    public partial class frmReceipt : Form
    {
        private List<order_items> order = new List<order_items>();
        private string customer;
        private DateTime date;
        private string total;
        private string user;

        public frmReceipt(List<order_items> _order, string _customer, DateTime _date, string _total, string _user)
        {
            InitializeComponent();
            order = _order;
            customer = _customer;
            date = _date;
            total = _total;
            user = _user;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            lblCustomer.Text = customer;
            lblTotal.Text = total;
            lblDate.Text = date.ToShortDateString();
            lblUser.Text = user;
            load_list(order);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (PrintDialog pd = new PrintDialog())
            {
                pd.ShowDialog();
            }
        }
    }

}
