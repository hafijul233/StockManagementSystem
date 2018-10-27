using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DAL;
using Models;


namespace StockManagementSystem.BLL
{
    public static class LoginController
    {
        static SqlConnection connect = new SqlConnection(DBConnection.connection());

        public static int LoginCheck(User user)
        {
            int result = 0;

            string query = "SELECT * FROM UserInfo WHERE Username ='" + user.Username + "' AND Password ='" + user.Password + "'";

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
    }
}
