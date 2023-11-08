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
        private void calcPack(TextBox t) => packEPS.Text = (double.Parse(amountEPS.Text) / div(thikEPS.Text)).ToString();

        private void isMark(string[] row) { if (EpsList.Last().Mark.Equals(markEPS.Text)) { row[0] = ""; } }

        private void epsClear()
        {
            selectDefaultItem(new[] { markEPS, thikEPS }); amountEPS.Clear(); packEPS.Clear(); fillEnable(new Control[] { thikEPS, amountEPS, packEPS, addEpsToOrderButton }, false);
        }

        private double div(string s) { if (s.Equals("8")) { return 0.32; }; return 0.3; }
    }
}
