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
using StockManagementSystem.BLL;
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

        private void CompanySetup_Load(object sender, EventArgs e)
        {
            DisplayList();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string categoryName = CompanynameTextBox.Text;

            if (categoryName == String.Empty)
            {
                WarningLabel.Text = "Input Category Name is Empty";
            }
            else if (CompanyController.TestCompanyName(categoryName) == (int)Utilities.SearchResult.Found)
            {
                WarningLabel.Text = categoryName + " is Already Exist.";
            }
            else if (CompanyController.InsertCompany(categoryName) != 0)
            {
                WarningLabel.Text = categoryName + " Added to Company List.";
            }
            else
            {
                WarningLabel.Text = categoryName + " Insertation Failed.";
            }

            DisplayList();
        }

        private void DisplayList()
        {
            List<string> categoryList = new List<string>();

            CompanyNamelistView.Clear();
            categoryList.Clear();

            CompanyNamelistView.Columns.Add("SI");
            CompanyNamelistView.Columns.Add("Company Name");

            categoryList = CompanyController.GetCompanyList();

            for (int i = 1; i < categoryList.Count; i++)
            {
                string[] arr = new string[2];
                ListViewItem itm;
                arr[0] = i.ToString();
                arr[1] = categoryList[i].ToString();
                itm = new ListViewItem(arr);
                CompanyNamelistView.Items.Add(itm);
            }
        }
    }
}
