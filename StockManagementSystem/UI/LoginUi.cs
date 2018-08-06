using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StockManagementSystem.UI;
using StockManagementSystem.Libraries;
using StockManagementSystem.Models;
using StockManagementSystem.DAL;
using StockManagementSystem.BLL;
using StockManagementSystem.Utilities;

namespace StockManagementSystem
{
    public partial class LoginUi : Form
    {
        SqlConnection con = new SqlConnection(DBConnection.connection());

        public LoginUi()
        {
            InitializeComponent();
        }

        private void LoginUi_Load(object sender, EventArgs e)
        {
            /*connection = new SqlConnection(DatabaseConnection.ConnectionString());
            
            if(connection.State != ConnectionState.Open)
            {
                var dialogueResult = MessageBox.Show("There is a Problem Setting up a Database Connection.", configuration._prgogramTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(dialogueResult == DialogResult.OK)
                {
                    //Application.Exit();
                }
                else
                {
                    //e.Cancel = true;
                }
            }*/
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            /*string username = UserNameTextBox.Text;
            string password = PassWordTextBox.Text;

            if (username == String.Empty || password == String.Empty)
            {
                MessageBox.Show("Input Field is Empty");
            }

            else
            {
                User person = new User(username, password);

                if (LoginController.LoginCheck(person) != 0)
                {*/
                    MainPage dashboard = new MainPage();
                    Hide();
                    dashboard.Show();
                /*}
                else
                {
                    var dialogueResult = MessageBox.Show("User Information Didn't Match", Libraries.Configuration._prgogramTitle,
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (dialogueResult == DialogResult.Retry)
                    {
                        UserNameTextBox.Text = String.Empty;
                        PassWordTextBox.Text = String.Empty;
                    }
                }
            }*/
        }

        private void RegisterlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please Contact System Administrator for Account Information. @ 01710534092.", Configuration._prgogramTitle,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ForgotPassWordlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordReceovery passwordReceovery = new PasswordReceovery();
            this.Hide();
            passwordReceovery.Show();
        }

        private void LoginUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseMessage.ApplicationClose(sender, e);
        }
    }
}
