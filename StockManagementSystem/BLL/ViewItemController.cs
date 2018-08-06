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
    public static class ViewItemController
    {
        private static int result = 0;

        static SqlConnection connect = new SqlConnection(DBConnection.connection());

        public static List<string> GetItemList(string query)
        {
            List<string> itemList = new List<string>();

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
    }
}
