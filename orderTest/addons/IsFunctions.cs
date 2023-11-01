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
        private bool isLast(int count)
        {
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        //реквізити
        private bool isPH(string ph)
        {
            if (ph.Contains("---")) { return true; }
            return false;
        }

        //пінопласт
        private void isMark(string[] row)
        {
            if (EpsList.Last().Mark.Equals(markEPS.Text))
            {
                row[0] = "";
            }
        }

        private void epsClear()
        {
            markEPS.SelectedIndex = 0;
            thikEPS.SelectedIndex = 0;
            thikEPS.Enabled = false;
            amountEPS.Clear();
            amountEPS.Enabled = false;
            packEPS.Clear();
            packEPS.Enabled = false;

            addEpsToOrderButton.Enabled = false;
        }

        private double div(string s)
        {
            if (s.Equals("8")) { return 0.32; }; return 0.3;
        }

        //додаткові
        private void addClear()
        {
            nameADD.SelectedIndex = 0;
            meterADD.SelectedIndex = 0;
            meterADD.Enabled = false;
            amountADD.Clear();
            amountADD.Enabled = false;

            addAddToOrderButton.Enabled = false;
        }
    }
}
