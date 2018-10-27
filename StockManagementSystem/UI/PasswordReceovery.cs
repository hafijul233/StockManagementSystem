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
using Models;
using StockManagementSystem.Libraries;
using StockManagementSystem.DAL;
using StockManagementSystem.Utilities;

namespace StockManagementSystem.UI
{
    public partial class PasswordReceovery : Form
    {
        SqlConnection connect = new SqlConnection(DBConnection.connection());

        public PasswordReceovery()
        {
            InitializeComponent();
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            User person = new User(UsernameTextBox.Text, PasswordTextBox.Text, FullnameTextBox.Text);

            string query = "SELECT * FROM UserInformation WHERE Username ='" + person.Username + "' OR Password = '" + person.Password + "' OR FullName = '" + person.FullName + "'";

            SqlCommand command = new SqlCommand(query, connect);
            connect.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                
                string Username = dr["Username"].ToString();
                string Password = dr["Password"].ToString();
                string FullName = dr["FullName"].ToString();

                User personinfo = new User(Username, Password, FullName);

                MessageBox.Show("\t\tUser Information\n==================================\nFullname: " +
                    personinfo.FullName + "\nUsername: " + personinfo.Username + "\nPassword: " + personinfo.Password, 
                        Libraries.Configuration._prgogramTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                var dialoguResult = MessageBox.Show("Input Username, Password or Full Name Didn't match.", Libraries.Configuration._prgogramTitle,
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (dialoguResult == DialogResult.OK)
                {
                    UsernameTextBox.Text = String.Empty;
                    PasswordTextBox.Text = String.Empty;
                    FullnameTextBox.Text = String.Empty;
                }
                else if(dialoguResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            connect.Close();

        }

        private void PasswordReceovery_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseMessage.ApplicationClose(sender, e);
        }
    }
}
