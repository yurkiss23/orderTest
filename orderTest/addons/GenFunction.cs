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
        private bool isLast(int count) { if (count > 0) { return true; } return false; }

        private void isNullPosition(ComboBox a, Control b) { if (a.SelectedIndex != 0) { b.Enabled = true; } else { b.Enabled = false; } }

        private void selectDefaultItem(ComboBox[] cb) { foreach (ComboBox cbItem in cb) { cbItem.SelectedIndex = 0; } }

        private void fillEnable(Control[] ctrs, bool state, string type = "t") { foreach (Control c in ctrs) { c.Enabled = state; } }
    }
}
