using StockManagementSystem.BLL;
using StockManagementSystem.DAL;
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

namespace StockManagementSystem.UI
{
    public partial class ViewItems : Form
    {
        public ViewItems()
        {
            InitializeComponent();
        }

        private void ViewItems_Load(object sender, EventArgs e)
        {
            List<string> companyList = new List<string>();
            List<string> categoryList = new List<string>();

            CompanyNameComboBox.Items.Clear();
            CategoryNameComboBox.Items.Clear();

            companyList = ViewItemController.GetCompanyList();
            categoryList = ViewItemController.GetCategoryList();

            foreach (var item in companyList)
            {
                CompanyNameComboBox.Items.Add(item.ToString());
            }

            foreach (var item in categoryList)
            {
                CategoryNameComboBox.Items.Add(item.ToString());
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(CategoryNameComboBox.Text == String.Empty || CompanyNameComboBox.Text == String.Empty)
            {
                WarningLabel.Text = "Selection Box is Empty";
            }
            else
            {
                SqlConnection connect = new SqlConnection(DBConnection.connection());

                string query = "SELECT DISTINCT Name, CategoryName, CompanyName, ReorderLevel, AvailableQuantity" + 
                               " FROM ItemInfo WHERE CategoryName = '" + CategoryNameComboBox.Text + "' AND CompanyName = '" + CompanyNameComboBox.Text + "' ";

                SqlCommand command = new SqlCommand(query, connect);

                if (connect.State == ConnectionState.Open)
                    connect.Close();
                else
                    connect.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    int serial = 1;
                    while (dataReader.Read())
                    {
                        string Name = dataReader["Name"].ToString();
                        string Company = dataReader["CompanyName"].ToString();
                        string Category = dataReader["CategoryName"].ToString();
                        string AvaliableQty = Convert.ToString(dataReader["AvailableQuantity"]);
                        string ReorderLevel = Convert.ToString(dataReader["ReorderLevel"]);
                        string si = Convert.ToString(serial);
                        var lvi = new ListViewItem(new[] { si, Name, Company, Category, AvaliableQty, ReorderLevel });
                        ItemsNamelistView.Items.Add(lvi);

                        serial++;
                    }
                }

                connect.Close();
            }
        }
    }
}
