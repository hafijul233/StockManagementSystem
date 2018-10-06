using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.DAL;
using StockManagementSystem.Models;

namespace StockManagementSystem.UI
{
    public partial class ViewSales : Form
    {
        SqlConnection connect = new SqlConnection(DBConnection.connection());

        int si = 1;

        public ViewSales()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string startDate = StartDatePicker.Text;
            string endDate = EndDatePicker.Text;

            List<StockReport> ItemSalesList = new List<StockReport>();

            SalesListView.Clear();
            ItemSalesList.Clear();

            string query = @"SELECT ItemName, StockOutQuantity FROM StockReport WHERE SalesFlag = 1";

            SqlCommand command = new SqlCommand(query, connect);

            if (connect.State == ConnectionState.Open)
                connect.Close();
            else
                connect.Open();

            SqlDataReader dataReader = command.ExecuteReader();

            SalesListView.Columns.Add("SI");
            SalesListView.Columns.Add("Item Name");
            SalesListView.Columns.Add("Quantity");



            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    string[] arr = new string[3];
                    ListViewItem itm;

                    arr[0] = si.ToString();
                    arr[1] = dataReader["ItemName"].ToString();
                    arr[2] = dataReader["StockOutQuantity"].ToString();
               
                    itm = new ListViewItem(arr);
                    SalesListView.Items.Add(itm);

                    si++;
                }
            }
            else
            {
                
            }

            connect.Close();
            
        }
    }
}
