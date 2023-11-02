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
        private static Panel[] panels;
        static private string path = @"e:\work\dev\orderUST\order.txt";

        public Form1()
        {
            InitializeComponent();

            //реквізити
            headerPanel.Location = new Point(0, 0);
            headerPanel.Size = new Size(753, 400);

            dateHead.Enabled = true;

            //eps
            epsPanel.Location = new Point(0, 0);
            epsPanel.Size = new Size(753, 400);

            markEPS.SelectedIndex = 0;
            thikEPS.SelectedIndex = 0;

            //додаткові
            addPanel.Location = new Point(0, 0);
            addPanel.Size = new Size(753, 300);

            nameADD.SelectedIndex = 0;
            meterADD.SelectedIndex = 0;
        }

        private void downToFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(downToFile.Text);

            //File.AppendAllText(path, addEPS + "\n");
        }
    }
}
