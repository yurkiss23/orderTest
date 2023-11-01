using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1 : Form
    {
        private void dateHead_ValueChanged(object sender, EventArgs e) { numberHead.Enabled = true; commentHead.Enabled = true; clearHead.Enabled = true; }

        private void numberHead_Enter(object sender, EventArgs e) { clearText(numberHead); }

        private void numberHead_TextChanged(object sender, EventArgs e) { clientHead.Enabled = true; }

        private void numberHead_Leave(object sender, EventArgs e) { orderLabel.Text = "замовлення №" + numberHead.Text; isFill((TextBox)sender, "#", fillArray(clientHead, new(), new(), new()) ); }

        private void clientHead_Enter(object sender, EventArgs e) { clearText(clientHead); }

        private void clientHead_TextChanged(object sender, EventArgs e) { markHead.Enabled = true; vehicleHead.Enabled = true; addressHead.Enabled = true; driverHead.Enabled = true; }

        private void clientHead_Leave(object sender, EventArgs e) { isFill((TextBox)sender, "замовник", fillArray(markHead, vehicleHead, addressHead, driverHead)); }

        private void markHead_Enter(object sender, EventArgs e) { clearText(markHead); }

        private void markHead_Leave(object sender, EventArgs e) { isFill((TextBox)sender, "марка"); }

        private void vehicleHead_Enter(object sender, EventArgs e) { clearText(vehicleHead); }

        private void vehicleHead_Leave(object sender, EventArgs e) { isFill((TextBox)sender, "машина"); }

        private void addressHead_Enter(object sender, EventArgs e) { clearText(addressHead); }

        private void addressHead_Leave(object sender, EventArgs e) { isFill((TextBox)sender, "адреса"); }

        private void driverHead_Enter(object sender, EventArgs e) { clearText(driverHead); }

        private void driverHead_Leave(object sender, EventArgs e) { isFill((TextBox)sender, "водій"); }

        private void clearHead_MouseHover(object sender, EventArgs e)
        {
            clearHead.BackColor = Color.LightCoral;
        }

        private void clearHead_MouseLeave(object sender, EventArgs e)
        {
            clearHead.BackColor = Color.MistyRose;
        }

        private void clearHead_Click(object sender, EventArgs e)
        {
            numberHead_Enter(sender, e); clientHead_Enter(sender, e);
        }

        private void addHeadData_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("header");
        }
    }
}
