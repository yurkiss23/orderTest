using orderTest.models;
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
        private static List<epsModel> EpsList = new List<epsModel>();
        static private string path = @"e:\work\dev\orderUST\order.txt";
        //private object? addEPS;

        public Form1()
        {
            InitializeComponent();

            //epsViewModel DataContext = new epsViewModel();

            //markEPS.DataBindings.Add(new Binding("Text", DataContext, "Mark", true));
            //thikEPS.DataBindings.Add(new Binding("Text", DataContext, "Thikness", true));
            //amountEPS.DataBindings.Add(new Binding("Text", DataContext, "Amount", true));
            //packEPS.DataBindings.Add(new Binding("Text", DataContext, "Pack", true));
        }

        private void showList()
        {
            string listTXT = "";
            if (EpsList.Count > 0)
            {
                foreach (var item in EpsList)
                {
                    listTXT += (item.ToString() + ';');
                }
            }
            MessageBox.Show("додано!",listTXT);
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            if (EpsList.Count > 0)
            {
                foreach (var item in EpsList)
                {
                    //MessageBox.Show(item.Mark);

                }
            }
            epsModel addEPS = new epsModel();
            //addEPS += (',' + amountEPS.Text + ',' + packEPS.Text);
            EpsList.Add(new epsModel { Mark = markEPS.Text, Thikness = int.Parse(thikEPS.Text), Amount = double.Parse(amountEPS.Text), Pack = int.Parse(packEPS.Text) });

            epsList.Visible = true;
            ListViewItem epsListItem = new ListViewItem(markEPS.Text);
            ListViewItem epsListVeiwSubItem = new ListViewItem(thikEPS.Text);
            epsListItem.SubItems.Add(epsListVeiwSubItem.Text);
            epsList.Items.Add(epsListItem);


            //showList();
            markEPS.SelectedIndex = 0;
            thikEPS.SelectedIndex = 0;
            amountEPS.Text = "";
            packEPS.Text = "";
        }
        private void downToFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(downToFile.Text);

            //File.AppendAllText(path, addEPS + "\n");
        }

        private void markEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //addEPS = markEPS.SelectedItem.ToString();
        }

        private void thikEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //addEPS += (',' + thikEPS.SelectedItem.ToString());
        }
    }
}
