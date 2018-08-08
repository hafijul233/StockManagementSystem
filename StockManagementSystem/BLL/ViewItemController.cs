using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DAL;
using StockManagementSystem.Models;


namespace StockManagementSystem.BLL
{
    public static class ViewItemController
    {
        private static int result = 0;

        static SqlConnection connect = new SqlConnection(DBConnection.connection());

        public static List<Item> GetItemList(string query)
        {
            List<Item> itemList = new List<Item>();

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
                    /*string item = dataReader.GetString(dataReader.GetOrdinal("Name"));
                    itemList.Add(item);*/
                }
            }
            else
            {
                /*string value = Utilities.SearchResult.NotFound.ToString();
                itemList.Add(value);*/
            }

            connect.Close();

            return itemList;
        }

        public static List<string> GetCompanyList()
        {
            List<string> companyList = new List<string>();

            string query = "SELECT DISTINCT CompanyName FROM ItemInfo";

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
                    string company = dataReader.GetString(dataReader.GetOrdinal("CompanyName"));
                    companyList.Add(company);
                }
            }
            else
            {
                string value = Utilities.SearchResult.NotFound.ToString();
                companyList.Add(value);
            }

            connect.Close();

            return companyList;
        }

        public static List<string> GetCategoryList()
        {
            List<string> categoryList = new List<string>();

            string query = "SELECT DISTINCT CategoryName FROM ItemInfo";

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
                    string category = dataReader.GetString(dataReader.GetOrdinal("CategoryName"));
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
    }
}
