using StockManagementSystem.Libraries;
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

namespace StockManagementSystem.UI
{
    public partial class ItemSetup : Form
    {
        Configuration configuration = new Configuration();

        SqlConnection con = new SqlConnection(@"server=HRIDOY-PC\SQLEXPRESS; database=StockManagementSystem; integrated security=true;");

        public ItemSetup()
        {
            InitializeComponent();
        }

        private void ItemSetup_Load(object sender, EventArgs e)
        {

        }
    }
}
