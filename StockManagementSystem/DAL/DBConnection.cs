using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAL
{
    public static class DBConnection
    {
        public static string connection()
        {
            string conString = @"server=DESKTOP-C43O4N8; database=StockManagementSystem; integrated security=true;";

            return conString;
        }
    }
}
