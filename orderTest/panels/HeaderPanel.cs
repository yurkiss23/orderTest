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
            if (ph.Contains("---")) { return true; }
            return false;
        }

        private void dateHead_ValueChanged(object sender, EventArgs e)
        {
            numberHead.Enabled = true;
            commentHead.Enabled = true;
        }

        private void numberHead_Enter(object sender, EventArgs e)
        {
            if (isPH(numberHead.Text)) { numberHead.Clear(); }
        }

        private void numberHead_TextChanged(object sender, EventArgs e)
        {
            clientHead.Enabled = true;
        }

        private void numberHead_Leave(object sender, EventArgs e)
        {
            orderLabel.Text = "замовлення №" + numberHead.Text;
            if (!numberHead.Text.Any()) { numberHead.Text = "---#---"; clientHead.Enabled = false; }
        }

        private void clientHead_Enter(object sender, EventArgs e)
        {
            if (isPH(clientHead.Text)) { clientHead.Clear(); }
        }

        private void clientHead_TextChanged(object sender, EventArgs e)
        {
            markHead.Enabled = true; vehicleHead.Enabled = true; addressHead.Enabled = true; driverHead.Enabled = true;
        }

        private void clientHead_Leave(object sender, EventArgs e)
        {
            if (!clientHead.Text.Any())
            {
                clientHead.Text = "---замовник---"; markHead.Enabled = false; vehicleHead.Enabled = false;
                addressHead.Enabled = false; driverHead.Enabled = false;
            }
        }

        private void markHead_Enter(object sender, EventArgs e)
        {
            if(isPH(markHead.Text)) { markHead.Clear(); }
        }

        private void markHead_Leave(object sender, EventArgs e)
        {
            if(!markHead.Text.Any()) { markHead.Text = "---марка---"; }
        }

        private void vehicleHead_Enter(object sender, EventArgs e)
        {
            if (isPH(vehicleHead.Text)) { vehicleHead.Clear(); }
        }

        private void vehicleHead_Leave(object sender, EventArgs e)
        {
            if(!vehicleHead.Text.Any()) { vehicleHead.Text = "---машина---"; }
        }

        private void addressHead_Enter(object sender, EventArgs e)
        {

        }

        private void addressHead_Leave(object sender, EventArgs e)
        {

        }

        private void driverHead_Enter(object sender, EventArgs e)
        {

        }

        private void driverHead_Leave(object sender, EventArgs e)
        {

        }

        private void addHeadData_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("header");
        }
    }
}
