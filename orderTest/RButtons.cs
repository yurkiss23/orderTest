using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1 : Form
    {
        private void panelEnVis(Panel panel)
        {
            foreach (var item in panels)
            {
                item.Visible = false; item.Enabled = false;
            }
            panel.Enabled = true; panel.Visible = true;
        }

        private void radioButton1_Enter(object sender, EventArgs e)
        {
            panelEnVis(headerPanel);
        }

        private void radioButton2_Enter(object sender, EventArgs e)
        {
            panelEnVis(epsPanel);
        }

        private void radioButton3_Enter(object sender, EventArgs e)
        {
            panelEnVis(addPanel);
        }
    }
}
