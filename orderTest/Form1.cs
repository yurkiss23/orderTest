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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1 : Form
    {
        static private string path = @"e:\work\dev\orderUST\order.txt";
        static private Panel[] panels;
        static private Button[] addBut;

        public Form1()
        {
            InitializeComponent();

            initArrays();
            fillPanelProps(new Point(0, 0), new Size(753, 400), new[] { markEPS, thikEPS, nameADD, meterADD });
        }

        private void downToFile_EnabledChanged(object sender, EventArgs e) => isButtonStateChanged((Button)sender);

        private void downToFile_Click(object sender, EventArgs e)
        {
            if (downToFile.Text == "вивантажити замовлення")
            {
                MessageBox.Show(hd.ToString() + ", " + EpsList.ToString() + ", " + AddList.ToString());
                splitContainer1.Enabled = false; splitContainer1.Visible = false;
                orderLabel.Enabled = false; orderLabel.Visible = false;

                string orderJson = JsonSerializer.Serialize(hd);
                Label jsonLabel = new Label(); jsonLabel.Text = orderJson; jsonLabel.Location = new Point(5, 150); jsonLabel.AutoSize = true;
                Controls.Add(jsonLabel);
            }
            else
            {
                Close();
            }

            resetAll();

            //File.AppendAllText(path, addEPS + "\n");

        }
    }
}
