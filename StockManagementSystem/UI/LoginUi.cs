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
using StockManagementSystem.DAL;

namespace StockManagementSystem
{
    public partial class LoginUi : Form
    {
        Configuration configuration = new Configuration();
        SqlConnection connection;

        public LoginUi()
        {
            InitializeComponent();
        }

        private void LoginUi_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(DatabaseConnection.ConnectionString());
            
            if(connection.State == ConnectionState.Open)
            {
                var dialogueResult = MessageBox.Show("There is a Problem Setting up a Database Connection.", configuration._prgogramTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(dialogueResult == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    //e.Cancel = true;
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UserNameTextBox.Text == "admin" && PassWordTextBox.Text == "admin")
            {
                MainPage dashboard = new MainPage();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                var dialoguResult = MessageBox.Show("Input Username or Password Didn't match.", configuration._prgogramTitle,
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if(dialoguResult == DialogResult.Retry)
                {
                    UserNameTextBox.Text = String.Empty;
                    PassWordTextBox.Text = String.Empty;
                }
            }


        }

        private void RegisterlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please Contact System Administrator for Account Information. @ 01710534092.", configuration._prgogramTitle,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ForgotPassWordlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordReceovery passwordReceovery = new PasswordReceovery();
            this.Hide();
            passwordReceovery.Show();
        }
    }
}
