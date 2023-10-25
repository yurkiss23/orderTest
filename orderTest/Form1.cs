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

        private bool isLast()
        {
            if (EpsList.Count > 0)
            {
                //MessageBox.Show(EpsList.Count.ToString());
                return true;
            }
            return false;
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            //новий рядок
            calcAmount();
            //if (amountEPS.Text.Count() == 0)
            //{
            //    amountEPS.AppendText((int.Parse(packEPS.Text) * .3).ToString());
            //}
            string[] addEPS = { markEPS.Text, thikEPS.Text, amountEPS.Text, packEPS.Text };

            //перевірка: заповненість, чи є вже дані в списку, чи збігається марку
            //isFill(), isLast(), iaMark()
            if (isLast())
            {
                if (EpsList.Last().Mark.Equals(markEPS.Text))
                {
                    addEPS[0] = "";
                }
                
            }

            //додаємо рядок в таблицю на формі
            epsData.Rows.Add(addEPS);
            epsData.Visible = true;

            //додаємо eps в замовлення
            EpsList.Add(new epsModel { Mark = markEPS.Text, Thikness = int.Parse(thikEPS.Text), Amount = double.Parse(amountEPS.Text), Pack = int.Parse(packEPS.Text) });

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

        private void calcAmount()
        {
            if (amountEPS.Text.Count() == 0)
            {
                amountEPS.AppendText((int.Parse(packEPS.Text) * .3).ToString());
            }
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

        private void packEPS_Leave(object sender, EventArgs e)
        {
            calcAmount();
        }
    }
}
