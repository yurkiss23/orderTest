using orderTest.models;
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
        //all
        private bool isLast(int count) { if (count > 0) { return true; } return false; }

        private void isNullPosition(ComboBox a, Control b) { if (a.SelectedIndex != 0) { b.Enabled = true; } else { b.Enabled = false; } }

        private void selectDefaultItem(ComboBox[] cb) { foreach (ComboBox cbItem in cb) { cbItem.SelectedIndex = 0; } }

        private void fillEnable(Control[] ctrs, bool state, string type = "t") { foreach (Control c in ctrs) { c.Enabled = state; } }

        //реквізити
        private void txt(List<TextBox> list, string[] ph) { foreach (TextBox t in list) { t.Text = "---" + ph[list.IndexOf(t)] + "---"; } }

        private bool isPH(string ph) { if (ph.Contains("---")) { return true; } return false; }

        private void clearText(TextBox tb) { if(isPH(tb.Text)) { tb.Clear(); } }

        private void isFill(TextBox t, Control[] ctrs, bool state, string ph) { if (!t.Text.Any()) { txt(new List<TextBox> { t }, new[] { ph }); fillEnable(ctrs, state); } }

        private void headClear()
        {
            dateHead.ResetText();
            txt(new List<TextBox> { numberHead, clientHead, markHead, vehicleHead, addressHead, driverHead }, new[] { "#", "замовник", "марка", "машина", "адреса", "водій" });
            fillEnable(new[] { numberHead, clientHead, markHead, vehicleHead, addressHead, driverHead, commentHead }, false);
            fillEnable(new[] { clearHead, addHeadData }, false, "b");
        }

        //пінопласт

        private void isMark(string[] row) { if (EpsList.Last().Mark.Equals(markEPS.Text)) { row[0] = ""; } }

        private void epsClear()
        {
            markEPS.SelectedIndex = 0;
            thikEPS.SelectedIndex = 0; thikEPS.Enabled = false;
            amountEPS.Clear(); amountEPS.Enabled = false;
            packEPS.Clear(); packEPS.Enabled = false;

            addEpsToOrderButton.Enabled = false;
        }

        private double div(string s) { if (s.Equals("8")) { return 0.32; }; return 0.3; }

        //додаткові
        private void addClear()
        {
            nameADD.SelectedIndex = 0; meterADD.SelectedIndex = 0; meterADD.Enabled = false; amountADD.Clear(); amountADD.Enabled = false; addAddToOrderButton.Enabled = false;
        }
    }
}
