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
        private void addClear() { selectDefaultItem(new[] { nameADD, meterADD }); amountADD.Clear(); fillEnable(new Control[] { meterADD, amountADD, addAddToOrderButton }, false); }
    }
}
