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

namespace StockManagementSystem.UI
{
    public partial class CompanySetup : Form
    {
        SqlConnection con = new SqlConnection(DBConnection.connection());

        public CompanySetup()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = CompanynameTextBox.Text;
            if (name == String.Empty)
            {
                WarningLabel.Text = "Input Company Name is Empty";
            }
            else
            {
                string query = "SELECT Name FROM CompanyInfo WHERE Name ='" + name + "'";
                SqlCommand command = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    WarningLabel.Text = "Company is Already Exited.";
                    con.Close();
                }
                else
                {
                    con.Close();
                    query = @"INSERT INTO CompanyInfo(Name) VALUES ('" + name + "')";

                    command = new SqlCommand(query, con);
                    con.Open();

                    int isRowAffected = command.ExecuteNonQuery();

                    if (isRowAffected != 0)
                    {
                        WarningLabel.Text = name + "Added Successfully.";
                    }
                    else
                    {
                        WarningLabel.Text = name + "Insertation Failed.";
                    }
                    con.Close();
                }
            }

            dataLoad();
        }

        private void CompanySetup_Load(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void dataLoad()
        {
            string query = "SELECT Id AS SI, Name AS Company_Name FROM CompanyInfo";
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);

            DataTable CategoryTable = new DataTable();
            sqlDataAdapter.Fill(CategoryTable);

            CompanyDataGridView.DataSource = CategoryTable;

        }
    }
}
