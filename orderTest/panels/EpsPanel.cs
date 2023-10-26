using orderTest.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1 : Form
    {
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

        private double div(string s)
        {
            if (s.Equals("8")) { return 0.32; }; return 0.3;
        }

        private void markEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (markEPS.SelectedIndex != 0)
            {
                thikEPS.Enabled = true;
            }
            else
            {
                thikEPS.Enabled = false;
            }
        }

        private void thikEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (thikEPS.SelectedIndex != 0)
            {
                //packEPS.Enabled = true;
                amountEPS.Enabled = true;
            }
            else
            {
                //packEPS.Enabled = false;
                amountEPS.Enabled = false;
            }
        }

        private void amountEPS_Leave(object sender, EventArgs e)
        {
            packEPS.Enabled = true;
            packEPS.Text = ((double.Parse(amountEPS.Text) / div(thikEPS.Text)).ToString());
            addToOrderButton.Enabled = true;
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
    }
}
