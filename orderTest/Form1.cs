using orderTest.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1 : Form
    {
        static private string path = @"e:\work\dev\orderUST\order.txt";
        static private Panel[] panels;

        public Form1()
        {
            InitializeComponent();

            initArrays();
            fillPanelProps(new Point(0, 0), new Size(753, 400), new[] { markEPS, thikEPS, nameADD, meterADD });
        }

        private void downToFile_EnabledChanged(object sender, EventArgs e) => isButtonStateChanged((Button)sender);

        private void downToFile_Click(object sender, EventArgs e)
        {
            if(downToFile.Text=="вивантажити замовлення")
            {
                MessageBox.Show(hd.ToString() + ", " + EpsList.ToString() + ", " + AddList.ToString());
            }
            else
            {
                resetAll();
                downToFile.Enabled = false;
            }

            //File.AppendAllText(path, addEPS + "\n");

        }
    }
}
