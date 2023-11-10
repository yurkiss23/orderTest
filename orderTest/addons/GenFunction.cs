﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1: Form
    {
        private void selectDefaultItem(ComboBox[] cb) { foreach (ComboBox cbItem in cb) { cbItem.SelectedIndex = 0; } }

        private void initArrays()
        {
            panels = new[] { headerPanel, epsPanel, addPanel };
            addBut = new[] { addHeadData, addEpsToOrderButton, addAddToOrderButton };
            diffControlArray = new Control[] { numberHead, commentHead, clearHead };
            txtControlArray = new[] { markHead, vehicleHead, addressHead, driverHead };
            ph = new[] { "#", "замовник", "марка", "машина", "адреса", "водій" };
            epsControl = new Control[] { thikEPS, amountEPS, packEPS, addEpsToOrderButton };
        }

        private void enableButton() { if (hd != null && EpsList.Any()) { fillEnable(new[] { downToFile }, true); } }

        private void txtBold(Control c) { c.Font = new Font(c.Font, c.Font.Style | FontStyle.Bold | FontStyle.Underline); }

        private void resetAll() { headClear(txtControlArray.ToList()); epsClear(); addClear(); EpsList.Clear(); AddList.Clear(); downToFile.Text = "вийти"; }

        //is...
        private void isNum(TextBox tb, Control[] ctrl, TextBox tCtrl = null)
        {
            if (tb.Text != "")
            {
                try { int.Parse(tb.Text); if (tCtrl != null) { calcPack(tCtrl); } fillEnable(ctrl, true); }
                catch (Exception)
                {
                    try { double.Parse(tb.Text); if (tCtrl != null) { calcPack(tCtrl); } fillEnable(ctrl, true); }
                    catch (Exception ex)
                    {
                        if (tCtrl != null) { tCtrl.Clear(); } fillEnable(ctrl, false);
                        MessageBox.Show("потрібно ввести число!", ex.Message.ToString()); tb.SelectAll();
                    }
                }
            }
        }

        private bool isLast(int count) { if (count > 0) { return true; } return false; }

        private void isNullPosition(ComboBox a, Control b) { if (a.SelectedIndex != 0) { b.Enabled = true; } else { b.Enabled = false; } }

        private void isButtonStateChanged(Button b)
        {
            if (b.Enabled) { b.FlatStyle = FlatStyle.Popup; b.BackColor = Color.LightGreen; downToFile.Enabled = false; } else { b.FlatStyle = FlatStyle.System; }
        }

        private void isFill(TextBox t, Control[] ctrs, bool state, string ph) { if (!t.Text.Any()) { txt(new List<Control> { t }, new[] { ph }); fillEnable(ctrs, state); } }

        private bool isState(Control[] ctrl) { foreach (Control c in ctrl) { if (c.Enabled) { return false; } } return true; }

        //fill..
        private void fillEnable(Control[] ctrs, bool state) { foreach (Control c in ctrs) { c.Enabled = state; } }

        private void fillPanelProps(Point p, Size s, ComboBox[] cb) { foreach (Panel pn in panels) { pn.Location = p; pn.Size = s; } selectDefaultItem(cb); }
    }
}
