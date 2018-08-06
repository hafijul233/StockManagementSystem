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
    public partial class StockIn : Form
    {
        public StockIn()
        {
            InitializeComponent();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            List<string> companyList = new List<string>();
            List<string> categoryList = new List<string>();
            List<string> itemList = new List<string>();

            CompanyNameComboBox.Items.Clear();
            CategoryNameComboBox.Items.Clear();
            ItemNameComboBox.Items.Clear();

            companyList = CompanyController.GetCompanyList();
            categoryList = CategoryController.GetCategoryList();
            itemList = ItemController.GetItemList();

            foreach (var company in companyList)
            {
                CompanyNameComboBox.Items.Add(company.ToString());
            }

            foreach (var category in categoryList)
            {
                CategoryNameComboBox.Items.Add(category.ToString());
            }

            foreach (var item in itemList)
            {
                ItemNameComboBox.Items.Add(item.ToString());
            }

        }
    }
}
