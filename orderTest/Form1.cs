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

        public Form1()
        {
            InitializeComponent();

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
            
            //додаємо eps в замовлення
            EpsList.Add(new epsModel { Mark = markEPS.Text, Thikness = int.Parse(thikEPS.Text), Amount = double.Parse(amountEPS.Text), Pack = int.Parse(packEPS.Text) });

            //додаємо рядок в таблицю на формі
            string[] addEPS = { markEPS.Text, thikEPS.Text, amountEPS.Text, packEPS.Text };
            epsData.Rows.Add(addEPS);

            //очищаэмо поля вибору і введення
            epsClear();
        }

        private void isMark(epsModel epsModel, string mark)
        {
            if (epsModel.Mark == mark)
            {
                
            }
        }

        private void epsClear()
        {
            markEPS.SelectedIndex = 0;
            thikEPS.SelectedIndex = 0;
            amountEPS.Clear();
            packEPS.Clear();
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
