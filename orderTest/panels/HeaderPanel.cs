﻿using orderTest.models;
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
        private void dateHead_ValueChanged(object sender, EventArgs e) { fillEnable(new[] { numberHead, commentHead }, true); clearHead.Enabled = true; }

        private void numberHead_Enter(object sender, EventArgs e) => clearText(numberHead);

        private void numberHead_TextChanged(object sender, EventArgs e) => clientHead.Enabled = true;

        private void numberHead_Leave(object sender, EventArgs e) { orderLabel.Text = "замовлення №" + numberHead.Text; isFill((TextBox)sender, new[] { clientHead }, false, "#"); }

        private void clientHead_Enter(object sender, EventArgs e) => clearText(clientHead);

        private void clientHead_TextChanged(object sender, EventArgs e) => fillEnable(new[] { markHead, vehicleHead, addressHead, driverHead }, true);

        private void clientHead_Leave(object sender, EventArgs e) => isFill((TextBox)sender, new[] { markHead, vehicleHead, addressHead, driverHead }, false, "замовник");

        private void markHead_Enter(object sender, EventArgs e) => clearText(markHead);

        private void markHead_Leave(object sender, EventArgs e) => isFill(sender, addHeadData, "марка");

        private void vehicleHead_Enter(object sender, EventArgs e) => clearText(vehicleHead);

        private void vehicleHead_Leave(object sender, EventArgs e) => isFill(sender, addHeadData, "машина");

        private void addressHead_Enter(object sender, EventArgs e) => clearText(addressHead);

        private void addressHead_Leave(object sender, EventArgs e) => isFill(sender, addHeadData, "адреса");

        private void driverHead_Enter(object sender, EventArgs e) => clearText(driverHead);

        private void driverHead_Leave(object sender, EventArgs e) => isFill(sender, addHeadData, "водій");

        private void clearHead_MouseHover(object sender, EventArgs e) => clearHead.BackColor = Color.LightCoral;

        private void clearHead_MouseLeave(object sender, EventArgs e) => clearHead.BackColor = Color.MistyRose;

        private void clearHead_Click(object sender, EventArgs e) => headClear();

        private void addHeadData_Click(object sender, EventArgs e)
        {
            //рядок з реквізитами
            string[] addHead = { dateHead.Value.ToString(), numberHead.Text, clientHead.Text, markHead.Text, vehicleHead.Text,// trailerHead.CheckState.ToString(),
                addressHead.Text, driverHead.Text, commentHead.Text };

            //додаємо реквізити до замовлення
            headModel header = new headModel(addHead);

            //виводимо реквізити на форму
            Label headLabel = new Label(); headLabel.Text = header.ToString(); headLabel.Font = new Font("Calibri", 12); headLabel.Location = new Point(0, 300); headLabel.AutoSize = true;
            headerPanel.Controls.Add(headLabel);

            //очищаэмо поля вибору і введення
            headClear();
        }
    }
}
