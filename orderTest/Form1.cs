using orderTest.viewmodels;
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
        private static List<string> ppList = new List<string>();
        static private string path = @"e:\work\dev\orderUST\order.txt";
        private string addEPS;

        public Form1()
        {
            InitializeComponent();

            epsViewModel DataContext = new epsViewModel();
            markEPS.DataBindings.Add(new Binding("Text", DataContext, "Mark", true));
            thikEPS.DataBindings.Add(new Binding("Text", DataContext, "Thikness", true));
            amountEPS.DataBindings.Add(new Binding("Text", DataContext, "Amount", true));
            packEPS.DataBindings.Add(new Binding("Text", DataContext, "Pack", true));
            //addB.DataBindings.Add(new Binding("Command", DataContext, "AddEPS", true));
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
            //TableLayoutPanel epsTable = new TableLayoutPanel();
            addEPS += (',' + amountEPS.Text + ',' + packEPS.Text);
            epsList.Items.Add(addEPS);

            ppList.Add(addEPS);
            //showList();
            markEPS.SelectedIndex = 0;
            thikEPS.SelectedIndex = 0;
            amountEPS.Text = "";
            packEPS.Text = "";
        }
        private void downToFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(downToFile.Text);

            File.AppendAllText(path, "123\n");
        }

        private void markEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            addEPS = markEPS.SelectedItem.ToString();
        }

        private void thikEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            addEPS += (',' + thikEPS.SelectedItem.ToString());
        }
    }
}
