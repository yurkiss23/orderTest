using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1 : Form
    {
        private static List<string> ppList = new List<string>();
        static private string path = @"e:\work\dev\orderUST\order.txt";
        private string addEPS;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //showList();
        }

        private void showList()
        {
            string listTXT = "";
            if (ppList.Count > 0)
            {
                foreach (var item in ppList)
                {
                    listTXT += (item.ToString() + ';');
                }
            }
            MessageBox.Show("додано!",listTXT);
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            addEPS += (',' + amountPPtext.Text + ',' + packAmountPPtext.Text);
            ppList.Add(addEPS);
            showList();
            markPPcb.SelectedIndex = 0;
            thinkPPcb.SelectedIndex = 0;
            amountPPtext.Text = "";
            packAmountPPtext.Text = "";
        }
        private void downToFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(downToFile.Text);

            File.AppendAllText(path, "123\n");
        }

        private void markPPcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            addEPS = markPPcb.SelectedItem.ToString();
        }

        private void thinkPPcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            addEPS += (',' + thinkPPcb.SelectedItem.ToString());
        }

    }
}
