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
        private void radioButton1_Enter(object sender, EventArgs e) => panelEnVis(headerPanel);

        private void radioButton2_Enter(object sender, EventArgs e) => panelEnVis(epsPanel);

        private void radioEPS_Click(object sender, EventArgs e) => addItems();

        private void radioButton3_Enter(object sender, EventArgs e) => panelEnVis(addPanel);
    }
}
