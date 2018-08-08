using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.BLL;
using StockManagementSystem.DAL;
using StockManagementSystem.Models;



namespace StockManagementSystem.BLL
{
    public static class StockOutController
    {
        private static int result = 0;

        static SqlConnection connect = new SqlConnection(DBConnection.connection());

        public static int UpdateStock(StockReport item)
        {
            decimal stock = item.AvaliableQty - item.StockOutQty;

            string query = @"UPDATE ItemInfo SET AvailableQuantity = '" + stock + "' WHERE Name = '" + item.ItemName + "' AND " +
                            "CompanyName = '" + item.CompanyName + "'";

            SqlCommand command = new SqlCommand(query, connect);

            connect.Open();

            result = command.ExecuteNonQuery();

            if (result != 0)
                result = (int)Utilities.SearchResult.Found;

            else
                result = (int)Utilities.SearchResult.NotFound;

            connect.Close();

            return result;

        }

        public static int InsertStockOut(StockReport item, string flag)
        {
            string query = String.Empty;

            if(flag == "SALE")
            {
                query = @"INSERT INTO StockReport(ItemName, CompanyName, StockOutQuantity, SalesFlag) VALUES ( '" + item.ItemName + "', '" + item.CompanyName + "' ," + item.StockOutQty + ", 1 )";
            }

            else if(flag == "DAMAGE")
            {
                query = @"INSERT INTO StockReport(ItemName, CompanyName, StockOutQuantity, DamageFlag) VALUES ( '" + item.ItemName + "', '" + item.CompanyName + "' ," + item.StockOutQty + ", 1 )";
            }

            else if (flag == "LOST")
            {
                query = @"INSERT INTO StockReport(ItemName, CompanyName, StockOutQuantity, LostFlag) VALUES ( '" + item.ItemName + "', '" + item.CompanyName + "' ," + item.StockOutQty + ", 1 )";
            }

            SqlCommand command = new SqlCommand(query, connect);

            connect.Open();

            result = command.ExecuteNonQuery();

            if (result != 0)
                result = (int)Utilities.SearchResult.Found;

            else
                result = (int)Utilities.SearchResult.NotFound;

            connect.Close();

            return result;

        }
    }
}
