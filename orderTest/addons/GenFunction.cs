using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1: Form
    {
        private void isNum(TextBox tb)
        {
            if (tb.Text != "")
            {
                try { int.Parse(tb.Text); }
                catch (Exception) { try { double.Parse(tb.Text); } catch (Exception ex) { MessageBox.Show("потрібно ввести число!", ex.Message.ToString()); tb.SelectAll(); } }
            }
        }

        private bool isLast(int count) { if (count > 0) { return true; } return false; }

        private void isNullPosition(ComboBox a, Control b) { if (a.SelectedIndex != 0) { b.Enabled = true; b.ResetText(); } else { b.Enabled = false; } }

        private void selectDefaultItem(ComboBox[] cb) { foreach (ComboBox cbItem in cb) { cbItem.SelectedIndex = 0; } }

        private void fillEnable(Control[] ctrs, bool state, string type = "t") { foreach (Control c in ctrs) { c.Enabled = state; } }
    }
}
