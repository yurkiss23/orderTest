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
        private void fClear() { }

        private void isHead() => addClients.Enabled = radioHead.Checked ? true : false;

        private bool isAddCl() => addClients.Checked ? false : true;
    }
}
