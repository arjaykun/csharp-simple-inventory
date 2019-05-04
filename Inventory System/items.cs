using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    public class items
    {
        public int item_id { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public decimal price { get; set; }
        public int stocks { get; set; }

        public int get_stocks(int id)
        {
            int stocks = 0;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select * from items where item_id = '{id}'", conn);
                da.Fill(dt);
                DataRow row = dt.Rows[0];
                stocks = Convert.ToInt32(row["quantity"]);
            }
            return stocks;
        }
    }
}
