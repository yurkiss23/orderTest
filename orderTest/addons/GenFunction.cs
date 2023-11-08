using System;
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

        private void isButtonStateChanged(Button b) { if (b.Enabled) { b.FlatStyle = FlatStyle.Popup; b.BackColor = Color.LightGreen; } else { b.FlatStyle = FlatStyle.System; } }

        private void selectDefaultItem(ComboBox[] cb) { foreach (ComboBox cbItem in cb) { cbItem.SelectedIndex = 0; } }

        private void isFill(TextBox t, Control[] ctrs, bool state, string ph) { if (!t.Text.Any()) { txt(new List<Control> { t }, new[] { ph }); fillEnable(ctrs, state); } }

        private void fillEnable(Control[] ctrs, bool state) { foreach (Control c in ctrs) { c.Enabled = state; } }
    }
}
