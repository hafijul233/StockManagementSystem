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

namespace StockManagementSystem.UI
{
    public partial class CategorySetup : Form
    {
        public CategorySetup()
        {
            InitializeComponent();
        }

        private void CategorySetup_Load(object sender, EventArgs e)
        {
            DisplayList();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string categoryName = CategoynameTextBox.Text;

            if(categoryName == String.Empty)
            {
                WarningLabel.Text = "Input Category Name is Empty";
            }
            else if (CategoryController.TestCategoryName(categoryName) == (int)Utilities.SearchResult.Found)
            {
                WarningLabel.Text = categoryName + " is Already Exist.";
            }
            else if(CategoryController.InsertCategory(categoryName) != 0)
            {
                WarningLabel.Text = categoryName + " Added to Category List.";
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

            CategoryNamelistView.Clear();
            categoryList.Clear();

            CategoryNamelistView.Columns.Add("SI");
            CategoryNamelistView.Columns.Add("Category Name");

            categoryList = CategoryController.GetCategoryList();

            for(int i = 1; i<categoryList.Count; i++)
            {
                string[] arr = new string[2];
                    ListViewItem itm; 
                arr[0] = i.ToString();
                arr[1] = categoryList[i].ToString();
                itm = new ListViewItem(arr);
                CategoryNamelistView.Items.Add(itm);
            }
        }
    }
}
