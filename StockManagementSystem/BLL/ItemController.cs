using StockManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class ItemController
    {
        private static int result = 0;

        static SqlConnection connect = new SqlConnection(DBConnection.connection());

        public static List<string> GetItemList()
        {
            List<string> itemList = new List<string>();

            string query = "SELECT Name FROM ItemInfo";

            SqlCommand command = new SqlCommand(query, connect);

            if (connect.State == ConnectionState.Open)
                connect.Close();
            else
                connect.Open();

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    string item = dataReader.GetString(dataReader.GetOrdinal("Name"));
                    itemList.Add(item);
                }
            }
            else
            {
                string value = Utilities.SearchResult.NotFound.ToString();
                itemList.Add(value);
            }

            connect.Close();

            return itemList;
        }

        public static int TestItemName(string itemName)
        {
            string query = "SELECT Name FROM ItemInfo WHERE Name ='" + itemName + "'";

            SqlCommand command = new SqlCommand(query, connect);

            if (connect.State == ConnectionState.Open)
                connect.Close();
            else
                connect.Open();

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.Read())
                result = (int)Utilities.SearchResult.Found;

            else
                result = (int)Utilities.SearchResult.NotFound;

            connect.Close();

            return result;
        }
        public static int InsertItem(string itemName, string categoryName, string companyName, double reorderLevel)
        {
            string query = @"INSERT INTO ItemInfo(Name, CategoryName, CompanyName, ReorderLevel)" +
                            "VALUES ('" + itemName + "','" + categoryName + "','" + companyName + "','" + reorderLevel + "')";

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
