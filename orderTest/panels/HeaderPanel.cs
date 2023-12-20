using orderTest.models;
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
        static private headModel hd;
        static private Control[] diffControlArray;
        static private Control[] txtControlArray;
        static private Control[] addCltControlArray;
        private string[] addHead;

        //замовник/адреса
        private void clientHead_Enter(object sender, EventArgs e) => clearText(clientHead);

        private void clientHead_TextChanged(object sender, EventArgs e) => fillEnable(addressHead, true); //при зміні вмикається адреса

        private void clientHead_Leave(object sender, EventArgs e) => isFill((TextBox)sender, [addHeadData], addHeadData.Enabled, "замовник");

        private void addressHead_Enter(object sender, EventArgs e) => clearText(addressHead);

        private void addressHead_TextChanged(object sender, EventArgs e) => fillEnable(addHeadData, true);

        private void addressHead_Leave(object sender, EventArgs e) => isFill((TextBox)sender, [addHeadData], true, "адреса");

        //решта полів
        private void dateHead_ValueChanged(object sender, EventArgs e) => fillEnable(diffControlArray, true);

        private void numberHead_Enter(object sender, EventArgs e) => clearText(numberHead);

        private void numberHead_TextChanged(object sender, EventArgs e) => fillEnable(txtControlArray, true);//при зміні - вмикаються інші текстові поля

        private void numberHead_Leave(object sender, EventArgs e) { orderLabel.Text = "замовлення №" + numberHead.Text; isFill((TextBox)sender, [addHeadData], addHeadData.Enabled, "#"); }

        private void markHead_Enter(object sender, EventArgs e) => clearText(markHead);// fillEnable(new[] { addHeadData }, true); }

        private void markHead_TextChanged(object sender, EventArgs e) => fillEnable(clientHead, true);//при зміні вмикається замовник

        private void markHead_Leave(object sender, EventArgs e) => isFill((TextBox)sender, [addHeadData], addHeadData.Enabled, "марка");

        private void vehicleHead_Enter(object sender, EventArgs e) => clearText(vehicleHead);

        private void vehicleHead_Leave(object sender, EventArgs e) => isFill((TextBox)sender, [addHeadData], addHeadData.Enabled, "машина");

        private void driverHead_Enter(object sender, EventArgs e) => clearText(driverHead);

        private void driverHead_Leave(object sender, EventArgs e) => isFill((TextBox)sender, [addHeadData], addHeadData.Enabled, "водій");

        private void clearHead_MouseHover(object sender, EventArgs e) => clearHead.BackColor = Color.LightCoral;

        private void clearHead_MouseLeave(object sender, EventArgs e) => clearHead.BackColor = Color.MistyRose;

        private void clearHead_Click(object sender, EventArgs e) => headClear(txtControlArray.ToList());

        private void addHeadData_EnabledChanged(object sender, EventArgs e) => isButtonStateChanged((Button)sender);

        private void addHeadData_Click(object sender, EventArgs e)
        {
            //додати вигрузки?
            DialogResult result = MessageBox.Show("додати вигрузки?", "вигрузки", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes){ fillManyCltsForm(); }

            //замовники/адреси
            string clts = clients == 1 ? clientHead.Text : toStr(cltsList, clientHead.Text); string addrs = clients == 1 ? addressHead.Text : toStr(addrsList, addressHead.Text);
            //рядок з реквізитами
            addHead = [dateHead.Value.ToString(), numberHead.Text, clts, markHead.Text, vehicleHead.Text, driverHead.Text, addrs, commentHead.Text];

            //додаємо реквізити до замовлення
            hd = new headModel(addHead); txtBold(radioHead); radioHead.ForeColor = Color.DarkGreen;

            //виводимо реквізити на форму
            Label headLabel = new Label(); headLabel.Text = hd.ToString(); headLabel.Font = new Font("Calibri", 12); headLabel.Location = new Point(0, 300); headLabel.AutoSize = true;
            headerPanel.Controls.Add(headLabel);

            //вкл номер клієнта, eps і додаткові
            addItems(); fillEnable([radioEPS, radioAdd], true);

            //очищаэмо поля вибору і введення
            headClear(txtControlArray.ToList());

            enableButton();
        }
    }
}
