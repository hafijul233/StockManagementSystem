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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CategorySetupButton_Click(object sender, EventArgs e)
        {
            CategorySetup categorySetup = new CategorySetup();
            categorySetup.Show(this);
        }

        private void CompanySetupButton_Click(object sender, EventArgs e)
        {
            CompanySetup companySetup = new CompanySetup();
            companySetup.Show(this);
        }

        private void ItemSetupButton_Click(object sender, EventArgs e)
        {
            ItemSetup itemSetup = new ItemSetup();
            itemSetup.Show(this);
        }

        private void StockInButton_Click(object sender, EventArgs e)
        {
            StockIn stockIn = new StockIn();
            stockIn.Show(this);

        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            StockOut stockOut = new StockOut();
            stockOut.Show(this);
        }

        private void ViewItemsButtons_Click(object sender, EventArgs e)
        {
            ViewItems viewItems = new ViewItems();
            viewItems.Show(this);
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            ViewSales viewSales = new ViewSales();
            viewSales.Show(this);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show(this);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUi.ActiveForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
