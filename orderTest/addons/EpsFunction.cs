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
        static private Control[] epsControl;

        private void calcPack(TextBox t) => packEPS.Text = (double.Parse(amountEPS.Text) / (thikEPS.Text.Equals("8") ? 0.32 : 0.3)).ToString();

        private void isMark(string[] row) => row[0] = EpsList.Last().Mark.Equals(markEPS.Text) ? "" : row[0];

        private void epsClear() { selectDefaultItem(new[] { markEPS, thikEPS }); amountEPS.Clear(); packEPS.Clear(); fillEnable(epsControl, false); }
    }
}
