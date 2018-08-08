using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;
using StockManagementSystem.Models;


namespace StockManagementSystem.UI
{
    public partial class StockIn : Form
    {
        List<string> companyList = new List<string>();
        List<string> categoryList = new List<string>();
        List<string> itemList = new List<string>();

        public StockIn()
        {
            InitializeComponent();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            CompanyNameComboBox.Items.Clear();
            CategoryNameComboBox.Items.Clear();
            ItemNameComboBox.Items.Clear();

            companyList = ViewItemController.GetCompanyList();
            categoryList = ViewItemController.GetCategoryList();
            itemList = ItemController.GetItemNameList("SELECT Name FROM ItemInfo");

            foreach (var company in companyList)
            {
                CompanyNameComboBox.Items.Add(company.ToString());
            }

            foreach (var category in categoryList)
            {
                CategoryNameComboBox.Items.Add(category.ToString());
            }

            

        }

        private void CategoryNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            itemList.Clear();
            ItemNameComboBox.Items.Clear();

            string CategoryName = CategoryNameComboBox.Text;
            string CompanyName = CompanyNameComboBox.Text;

            itemList = ItemController.GetItemNameList("SELECT Name FROM ItemInfo WHERE CategoryName = '" + CategoryName + "' AND CompanyName = '" + CompanyName +"'");

            foreach (var item in itemList)
            {
                ItemNameComboBox.Items.Add(item.ToString());
            }

        }

        private void CompanyNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            itemList.Clear();
            ItemNameComboBox.Items.Clear();

            string CategoryName = CategoryNameComboBox.Text;
            string CompanyName = CompanyNameComboBox.Text;

            itemList = ItemController.GetItemNameList("SELECT Name FROM ItemInfo WHERE CategoryName = '" + CategoryName + "' AND CompanyName = '" + CompanyName + "'");

            foreach (var item in itemList)
            {
                ItemNameComboBox.Items.Add(item.ToString());
            }

        }

        private void ItemNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] StockStatus = new string[2];

            string itemName = ItemNameComboBox.Text;

            StockStatus = ItemController.GetStockValue(itemName);

            ReorderLevelLabel.Text = StockStatus[0];
            AvailableQuantityLabel.Text = StockStatus[1];
            
        }

        private void StockInTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = StockInTextBox.Text;

            foreach(char c in temp)
            {
                if(Char.IsDigit(c) == false && c != '.')
                {
                    WarningLabel.Text = "Only Digit and . are allowed.";
                }
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            item.Name = ItemNameComboBox.Text;
            item.Company = CompanyNameComboBox.Text;
            item.Category = CategoryNameComboBox.Text;
            item.ReorderLevel = Convert.ToDecimal(ReorderLevelLabel.Text);
            item.AvaliableQty = Convert.ToDecimal(AvailableQuantityLabel.Text);

            decimal stockinqty = Convert.ToDecimal(StockInTextBox.Text);

            if(ItemController.SetStockUpdate(item, stockinqty) != (int)Utilities.SearchResult.NotFound)
            {
                WarningLabel.Text = "StockIn Secussfull";
            }
            else
            {
                WarningLabel.Text = "StockIn Faild";
            }
        }
    }
}
