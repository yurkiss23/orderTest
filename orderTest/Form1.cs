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
        private static string[] HeaderData;
        private static List<epsModel> EpsList = new List<epsModel>();
        private static List<addModel> AddList = new List<addModel>();
        static private string path = @"e:\work\dev\orderUST\order.txt";

        public Form1()
        {
            InitializeComponent();

            //реквізити
            addHeadData.Enabled = true;

            headerPanel.Location = new Point(0, 0);
            headerPanel.Size = new Size(753, 200);

            //eps
            epsPanel.Location = new Point(0, 0);
            epsPanel.Size = new Size(753, 400);

            markEPS.SelectedIndex = 0;
            thikEPS.SelectedIndex = 0;

            //додаткові
            addAddToOrderButton.Enabled = true;

            addPanel.Location = new Point(0, 0);
            addPanel.Size = new Size(753, 300);
        }

        private void downToFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(downToFile.Text);

            //File.AppendAllText(path, addEPS + "\n");
        }
    }
}
