using StockManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(CategoryNameComboBox.Text == String.Empty && CompanyNameComboBox.Text == String.Empty)
            {
                WarningLabel.Text = "Selection Box is Empty";
            }
            else if(CategoryNameComboBox.Text == String.Empty && CompanyNameComboBox.Text != String.Empty)
            {

            }
        }
    }
}
