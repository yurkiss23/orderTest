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
        private static List<epsModel> EpsList = new List<epsModel>();
        static private string path = @"e:\work\dev\orderUST\order.txt";

        public Form1()
        {
            InitializeComponent();

            //реквізити

            //eps
            markEPS.SelectedIndex = 0;
            thikEPS.SelectedIndex = 0;

            //додаткові
        }

        private void downToFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(downToFile.Text);

            //File.AppendAllText(path, addEPS + "\n");
        }
    }
}
