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
        //private bool isLast(int count) { if (count > 0) { return true; } return false; }

        //private void isNullPosition(ComboBox a, Control b) { if (a.SelectedIndex != 0) { b.Enabled = true; } else { b.Enabled = false; } }

        //private void selectDefaultItem(ComboBox[] cb) { foreach (ComboBox cbItem in cb) { cbItem.SelectedIndex = 0; } }

        //private void fillEnable(Control[] ctrs, bool state, string type = "t") { foreach (Control c in ctrs) { c.Enabled = state; } }

        //реквізити
        //private void txt(List<Control> list, string[] ph) { foreach (TextBox t in list) { t.Text = "---" + ph[list.IndexOf(t)] + "---"; } }

        //private bool isPH(string ph) { if (ph.Contains("---")) { return true; } return false; }

        //private void clearText(TextBox tb) { if(isPH(tb.Text)) { tb.Clear(); } }

        //private void isFill(TextBox t, Control[] ctrs, bool state, string ph) { if (!t.Text.Any()) { txt(new List<Control> { t }, new[] { ph }); fillEnable(ctrs, state); } }

        //private void headClear(List<Control> cl)
        //{
        //    List<Control> tmpCtrTxt = new List<Control> { numberHead, clientHead }.Concat(cl).ToList();
        //    dateHead.ResetText();
        //    txt(tmpCtrTxt, new[] { "#", "замовник", "марка", "машина", "адреса", "водій" }); fillEnable(tmpCtrTxt.Concat(new List<Control> { clearHead, addHeadData }).ToArray(), false);
        //}

        //пінопласт

        //private void isMark(string[] row) { if (EpsList.Last().Mark.Equals(markEPS.Text)) { row[0] = ""; } }

        //private void epsClear()
        //{
        //    selectDefaultItem(new[] { markEPS, thikEPS }); amountEPS.Clear(); packEPS.Clear(); fillEnable(new Control[] { thikEPS, amountEPS, packEPS, addEpsToOrderButton }, false);
        //}

        //private double div(string s) { if (s.Equals("8")) { return 0.32; }; return 0.3; }

        //додаткові
        //private void addClear() { selectDefaultItem(new[] { nameADD, meterADD }); amountADD.Clear(); fillEnable(new Control[] { meterADD, amountADD, addAddToOrderButton }, false); }
    }
}
