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
        private void txt(TextBox tb, string ph) { tb.Text = "---" + ph + "---"; }

        private TextBox[] fillArray(TextBox a, TextBox b = null, TextBox c = null, TextBox d = null) { TextBox[] tArray = { a, b, c, d }; return tArray; }

        private bool isPH(string ph) { if (ph.Contains("---")) { return true; } return false; }

        private void clearText(TextBox tb) { if(isPH(tb.Text)) { tb.Clear(); } }

        private void isFill(TextBox tb, string ph) { if (!tb.Text.Any()) { txt(tb, ph); } }

        private void isFill(TextBox tb, string ph, TextBox[] asDis) { if (!tb.Text.Any()) { txt(tb, ph); foreach (TextBox b in asDis) { b.Enabled = false; } } }

        private void headClear()
        {
            dateHead.ResetText();
            txt(numberHead, "#"); numberHead.Enabled = false;
            txt(clientHead, "замовник"); clientHead.Enabled = false;
            txt(markHead, "марка"); markHead.Enabled = false;
            txt(vehicleHead, "машина"); vehicleHead.Enabled = false;
            txt(addressHead, "адреса"); addressHead.Enabled = false;
            txt(driverHead, "водій");driverHead.Enabled = false;
            commentHead.Enabled = false; clearHead.Enabled = false;

            addHeadData.Enabled = false;
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
            thikEPS.SelectedIndex = 0; thikEPS.Enabled = false;
            amountEPS.Clear(); amountEPS.Enabled = false;
            packEPS.Clear(); packEPS.Enabled = false;

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
            meterADD.SelectedIndex = 0; meterADD.Enabled = false;
            amountADD.Clear(); amountADD.Enabled = false;

            addAddToOrderButton.Enabled = false;
        }
    }
}
