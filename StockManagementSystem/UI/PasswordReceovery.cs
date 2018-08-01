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
using StockManagementSystem.Models;
using StockManagementSystem.Libraries;


namespace StockManagementSystem.UI
{
    public partial class PasswordReceovery : Form
    {
        Configuration configuration = new Configuration();
        SqlConnection con = new SqlConnection(@"server=HRIDOY-PC\SQLEXPRESS; database=StockManagementSystem; integrated security=true;");

        public PasswordReceovery()
        {
            InitializeComponent();
        }

        private void PasswordReceovery_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            User person = new User();
            person.Username = UsernameTextBox.Text;
            person.Password = PasswordTextBox.Text;
            person.FullName = FullnameTextBox.Text;

            string query = "SELECT * FROM UserInformation WHERE Username ='" + person.Username + "' OR Password = '" + person.Password + "' OR FullName = '" + person.FullName + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                person.FullName = dr["FullName"].ToString();
                User person2 = new User();
                person2.Username = dr["Username"].ToString();
                person2.Password = dr["Password"].ToString();
                person2.FullName = dr["FullName"].ToString();

                MessageBox.Show("\t\tUser Information\n==================================\nFullname: " +
                    person2.FullName + "\nUsername: " + person2.Username + "\nPassword: " + person2.Password, 
                        configuration._prgogramTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var dialoguResult = MessageBox.Show("Input Username, Password or Full Name Didn't match.", configuration._prgogramTitle,
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
            con.Close();

        }
    }
}
