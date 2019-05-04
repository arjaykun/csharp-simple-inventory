using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    public class Database
    {
        public static string LoadConnectionString()
        {
            return "Provider=System.Data.SqlClient;Data Source=.\\database.db;Version=3";
        }
    }
}
