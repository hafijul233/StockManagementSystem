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
    public partial class StockOut : Form
    {
        int serial = 0;

        List<string> companyList = new List<string>();
        List<string> categoryList = new List<string>();
        List<string> itemList = new List<string>();
        List<StockReport> stockOutList = new List<StockReport>();

        public StockOut()
        {
            InitializeComponent();
        }

        private void StockOut_Load(object sender, EventArgs e)
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

            serial = 1;
        }

        private void CategoryNameComboBox_SelectedValueChanged(object sender, EventArgs e)
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

        private void CompanyNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ItemNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] StockStatus = new string[2];

            string itemName = ItemNameComboBox.Text;

            StockStatus = ItemController.GetStockValue(itemName);

            ReorderLevelLabel.Text = StockStatus[0];
            AvailableQuantityLabel.Text = StockStatus[1];
        }

        private void StockOutTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal availableqty = Convert.ToDecimal(AvailableQuantityLabel.Text);
            string stockString = StockOutTextBox.Text;

            if (stockString != String.Empty)
            {
                foreach(char c in stockString)
                {
                    if(Char.IsDigit(c) == false && c != '.')
                    {
                        WarningLabel.Text = "Only Numbers and . allowed.";
                        return;
                    }
                }

                decimal stockOutvalue = Convert.ToDecimal(stockString);

                if(availableqty < stockOutvalue)
                {
                    WarningLabel.Text = "InSufficient Items in Stock";
                    StockOutTextBox.Text = String.Empty;
                }

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(StockOutTextBox.Text == String.Empty)
            {
                WarningLabel.Text = "Stock Out Value is Empty";
                return;
            }

            StockReport stockitem = new StockReport();

            stockitem.ItemName = ItemNameComboBox.Text;
            stockitem.CompanyName = CompanyNameComboBox.Text;
            stockitem.StockOutQty = Convert.ToDecimal(StockOutTextBox.Text);
            stockitem.AvaliableQty = Convert.ToDecimal(AvailableQuantityLabel.Text);
            stockOutList.Add(stockitem);

            string si = Convert.ToString(serial);

            var lvi = new ListViewItem(new[] { si, stockitem.ItemName, stockitem.CompanyName, stockitem.StockOutQty.ToString()});

            StockOutListView.Items.Add(lvi);
            serial++;

            StockOutTextBox.Text = String.Empty;
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            int Error = 0;

            foreach (StockReport item in stockOutList)
            {
                if(StockOutController.InsertStockOut(item, "SALE") != 0)
                {
                    if(StockOutController.UpdateStock(item) == 0)
                    {
                        Error = 1;
                        break;
                    }
                }
                else
                {
                    Error = 1;
                    break;
                }
            }

            if(Error == 0)
            {
                MessageBox.Show("All Stock Were Updated.");
            }
            else
            {
                MessageBox.Show("Stock Update Failed.");
            }
        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            int Error = 0;

            foreach (StockReport item in stockOutList)
            {
                if (StockOutController.InsertStockOut(item, "DAMAGE") != 0)
                {
                    if (StockOutController.UpdateStock(item) == 0)
                    {
                        Error = 1;
                        break;
                    }
                }
                else
                {
                    Error = 1;
                    break;
                }
            }

            if (Error == 0)
            {
                MessageBox.Show("All Stock Were Updated.");
            }
            else
            {
                MessageBox.Show("Stock Update Failed.");
            }
        }

        private void LostButton_Click(object sender, EventArgs e)
        {
            int Error = 0;

            foreach (StockReport item in stockOutList)
            {
                if (StockOutController.InsertStockOut(item, "LOST") != 0)
                {
                    if (StockOutController.UpdateStock(item) == 0)
                    {
                        Error = 1;
                        break;
                    }
                }
                else
                {
                    Error = 1;
                    break;
                }
            }

            if (Error == 0)
            {
                MessageBox.Show("All Stock Were Updated.");
            }
            else
            {
                MessageBox.Show("Stock Update Failed.");
            }

        }
    }
}
