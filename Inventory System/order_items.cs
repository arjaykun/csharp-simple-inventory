using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    public class order_items
    {
        public items item { get; set; }
        public int quantity { get; set; }
        public decimal subtotal
        {
            get { return item.price * quantity; }
        }
    }
}
