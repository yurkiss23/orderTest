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
        private void panelEnVis(Panel[] panels)
        {
            int i = 0;
            do
            {
                panels[i].Visible = false;
                panels[i].Enabled = false; i++;
            } while (i < panels.Length - 1);
            panels[i].Enabled = true;
            panels[i].Visible = true;
        }

        private void radioButton1_Enter(object sender, EventArgs e)
        {
            Panel[] panels = { epsPanel, addPanel, headerPanel };
            panelEnVis(panels);

            Header();
        }

        private void radioButton2_Enter(object sender, EventArgs e)
        {
            Panel[] panels = { headerPanel, addPanel, epsPanel };
            panelEnVis(panels);
        }

        private void radioButton3_Enter(object sender, EventArgs e)
        {
            Panel[] panels = { headerPanel, epsPanel, addPanel };
            panelEnVis(panels);

            Addict();
        }
    }
}
