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
using StockManagementSystem.Utilities;
using Models;

namespace StockManagementSystem.UI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(DBConnection.connection());

            string query = "SELECT Name, CategoryName, CompanyName, ReorderLevel, AvailableQuantity FROM ItemInfo WHERE AvailableQuantity <= ReorderLevel ORDER BY Id DESC";

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
                    Item item = new Item();

                    item.Name = dataReader["Name"].ToString();
                    item.Company = dataReader["CompanyName"].ToString();
                    item.Category = dataReader["CategoryName"].ToString();
                    item.AvaliableQty = Convert.ToDecimal(dataReader["AvailableQuantity"]);
                    item.ReorderLevel = Convert.ToDecimal(dataReader["ReorderLevel"]);
                    string si = Convert.ToString(serial);
                    var lvi = new ListViewItem(new[] { si, item.Name, item.Company, item.Category, item.AvaliableQty.ToString(), item.ReorderLevel.ToString() });
                    ItemsInfolistView.Items.Add(lvi);

                    serial++;
                }
            }

            connect.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseMessage.ApplicationClose(sender, e);
        }

        
    }
}
