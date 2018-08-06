using StockManagementSystem.BLL;
using StockManagementSystem.Libraries;
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
    public partial class ItemSetup : Form
    {

        public ItemSetup()
        {
            InitializeComponent();
        }

        private void ItemSetup_Load(object sender, EventArgs e)
        {
            List<string> companyList = new List<string>();
            List<string> categoryList = new List<string>();

            CompanyNameComboBox.Items.Clear();
            CategoryNameComboBox.Items.Clear();

            companyList = CompanyController.GetCompanyList();
            categoryList = CategoryController.GetCategoryList();

            foreach (var item in companyList)
            {
                CompanyNameComboBox.Items.Add(item.ToString());
            }

            foreach (var item in categoryList)
            {
                CategoryNameComboBox.Items.Add(item.ToString());
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string itemName = ItemNameTextBox.Text;
            string categoryName = CategoryNameComboBox.Text;
            string companyName = CompanyNameComboBox.Text;

            double reorderLevel = Convert.ToDouble(ReorderTextBox.Text);


            if (itemName == String.Empty || categoryName == String.Empty || companyName == String.Empty || ReorderTextBox.Text == String.Empty)
            {
                WarningLabel.Text = "Input Stream is Empty";
            }

            else if (ItemController.TestItemName(itemName) == (int)Utilities.SearchResult.Found)
            {
                WarningLabel.Text = itemName + " is Already Exist.";
            }
            else if (ItemController.InsertItem(itemName, categoryName, companyName, reorderLevel) != 0)
            {
                WarningLabel.Text = itemName + " Added to Items List.";
            }
            else
            {
                WarningLabel.Text = itemName + " Insertation Failed.";
            }
        }

        private void ReorderTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = ReorderTextBox.Text;

            foreach(char c in temp)
            {
                if(Char.IsDigit(c) == false && c != '.')
                {
                    WarningLabel.Text = "Only Numbers in Reorder Level";
                }
            }
        }
    }
}
