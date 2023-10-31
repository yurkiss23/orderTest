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
            if (!numberHead.Text.Any()) { clientHead.Enabled = false; }
            orderLabel.Text = "замовлення №" + numberHead.Text;
        }

        private void clientHead_Enter(object sender, EventArgs e)
        {
            if (isPH(clientHead.Text)) { clientHead.Clear(); }
        }

        private void clientHead_TextChanged(object sender, EventArgs e)
        {
            markHead.Enabled = true;
            vehicleHead.Enabled = true;
        }

        private void clientHead_Leave(object sender, EventArgs e)
        {
            if (!clientHead.Text.Any()) { markHead.Enabled = false; }
        }

        private void addHeadData_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("header");
        }
    }
}
