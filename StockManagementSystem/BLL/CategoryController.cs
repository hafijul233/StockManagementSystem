using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using StockManagementSystem.DAL;
using System.Data;

namespace StockManagementSystem.BLL
{
    public class CategoryController
    {
        private static int result = 0;

        static SqlConnection connect = new SqlConnection(DBConnection.connection());

        public static List<string> GetCategoryList()
        {
            List<string> categoryList = new List<string>();

            string query = "SELECT Name FROM CategoryInfo";

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
                    string category = dataReader.GetString(dataReader.GetOrdinal("Name"));
                    categoryList.Add(category);
                }
            }
            else
            {
                string value = Utilities.SearchResult.NotFound.ToString();
                categoryList.Add(value);
            }

            connect.Close();

            return categoryList;
        }

        public static int TestCategoryName(string categoryName)
        {
            string query = "SELECT Name FROM CategoryInfo WHERE Name ='" + categoryName + "'";

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
        public static int InsertCategory(string categoryName)
        {
            string query = @"INSERT INTO CategoryInfo(Name) VALUES ('" + categoryName + "')";

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
