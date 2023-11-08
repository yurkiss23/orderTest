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
        private void txt(List<Control> list, string[] ph) { foreach (TextBox t in list) { t.Text = "---" + ph[list.IndexOf(t)] + "---"; } }

        private bool isPH(string ph) { if (ph.Contains("---")) { return true; } return false; }

        private void clearText(TextBox tb) { if (isPH(tb.Text)) { tb.Clear(); } }

        private void headClear(List<Control> cl)
        {
            List<Control> tmpCtrTxt = new List<Control> { numberHead, clientHead }.Concat(cl).ToList();
            dateHead.ResetText();
            txt(tmpCtrTxt, new[] { "#", "замовник", "марка", "машина", "адреса", "водій" }); fillEnable(tmpCtrTxt.Concat(new List<Control> { clearHead, addHeadData }).ToArray(), false);
        }
    }
}
