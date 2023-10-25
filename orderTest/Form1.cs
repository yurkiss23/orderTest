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

            markEPS.SelectedIndex = 0;
            thikEPS.SelectedIndex = 0;
        }

        private bool isLast()
        {
            if (EpsList.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void isMark(string[] row)
        {
            if (EpsList.Last().Mark.Equals(markEPS.Text))
            {
                row[0] = "";
            }
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            //новий рядок
            string[] addEPS = { markEPS.Text, thikEPS.Text, amountEPS.Text, packEPS.Text };

            //перевірка: заповненість, чи є вже дані в списку, чи збігається марка
            if (isLast())
            {
                isMark(addEPS);
            }

            //додаємо рядок в таблицю на формі
            epsData.Rows.Add(addEPS);
            epsData.Visible = true;

            //додаємо eps в замовлення
            EpsList.Add(new epsModel { Mark = markEPS.Text, Thikness = int.Parse(thikEPS.Text), Amount = double.Parse(amountEPS.Text), Pack = int.Parse(packEPS.Text) });

            //очищаэмо поля вибору і введення
            epsClear();
        }

        private void epsClear()
        {
            markEPS.SelectedIndex = 0;
            thikEPS.SelectedIndex = 0;
            thikEPS.Enabled = false;
            amountEPS.Clear();
            amountEPS.Enabled = false;
            packEPS.Clear();
            packEPS.Enabled = false;

            addToOrderButton.Enabled = false;
        }

        private void downToFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(downToFile.Text);

            //File.AppendAllText(path, addEPS + "\n");
        }

        private void markEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (markEPS.SelectedIndex != 0)
            {
                thikEPS.Enabled = true;
            }
            else
            {
                thikEPS.Enabled=false;
            }
        }

        private void thikEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (thikEPS.SelectedIndex != 0)
            {
                packEPS.Enabled = true;
            }
            else
            {
                packEPS.Enabled=false;
            }
        }

        private void packEPS_Leave(object sender, EventArgs e)
        {
            amountEPS.Enabled = true;
            amountEPS.AppendText((int.Parse(packEPS.Text) * .3).ToString());
            addToOrderButton.Enabled = true;
        }
    }
}
