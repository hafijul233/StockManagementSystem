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
    class CompanyController
    {

        private static int result = 0;

        static SqlConnection connect = new SqlConnection(DBConnection.connection());

        public static List<string> GetCompanyList()
        {
            List<string> companyList = new List<string>();

            string query = "SELECT Name FROM CompanyInfo";

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
                    string company = dataReader.GetString(dataReader.GetOrdinal("Name"));
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

        public static int TestCompanyName(string companyName)
        {
            string query = "SELECT Name FROM CompanyInfo WHERE Name ='" + companyName + "'";

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
        public static int InsertCompany(string companyName)
        {
            string query = @"INSERT INTO CompanyInfo(Name) VALUES ('" + companyName + "')";

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
