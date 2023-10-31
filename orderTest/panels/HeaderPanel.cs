using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1 : Form
    {
        private bool isPH(string ph)
        {
            if (ph.Contains("---"))
            {
                return true;
            }
            return false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            clientData.Enabled = true;
            markData.Enabled = true;
        }

        private void clientData_Enter(object sender, EventArgs e)
        {
            if (isPH(clientData.Text))
            {
                clientData.Clear();
            }
        }

        private void addHeadData_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("header");
        }
    }
}
