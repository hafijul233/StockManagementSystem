using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Libraries;

namespace StockManagementSystem.Utilities
{
    public static class CloseMessage
    {
        public static void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you really want to Exit", Configuration._prgogramTitle,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
                Application.ExitThread();

            else
                e.Cancel = true;
        }
    }
}
