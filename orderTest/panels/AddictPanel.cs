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
        private void addClear()
        {
            nameADD.SelectedIndex = 0;
            meterADD.SelectedIndex = 0;
            meterADD.Enabled = false;
            amountADD.Clear();
            amountADD.Enabled = false;

            addAddToOrderButton.Enabled = false;
        }

        //private void selectMeter(string name)
        //{
        //    foreach (var item in nameADD.Items)
        //    {
        //        if (item.ToString().Equals(name))
        //        {
        //            meterADD.SelectedItem = item;
        //            break;
        //        }
        //    }

        //    //return meterADD.SelectedItem;
        //}

        private void nameADD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameADD.SelectedIndex != 0)
            {
                meterADD.Enabled = true;
            }
            else
            {
                meterADD.Enabled = false;
            }
        }

        private void meterADD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (meterADD.SelectedIndex != 0)
            {
                amountADD.Enabled = true;
            }
            else
            {
                amountADD.Enabled = false;
            }
        }

        private void amountADD_Leave(object sender, EventArgs e)
        {
            addAddToOrderButton.Enabled = true;
        }

        private void addAddToOrderButton_Click(object sender, EventArgs e)
        {
            //новий рядок
            string[] addADD = { nameADD.Text, meterADD.Text, amountADD.Text };

            //перевірка: заповненість, чи є вже дані в списку, чи збігається марка
            //if (isLast(AddList.Count))
            //{
            //    isMark(addADD);
            //}

            //додаємо рядок в таблицю на формі
            addData.Rows.Add(addADD);
            addData.Visible = true;

            //додаємо eps в замовлення
            AddList.Add(new addModel { Name = nameADD.Text, Meter = meterADD.Text, Amount = int.Parse(amountADD.Text) });

            //очищаэмо поля вибору і введення
            addClear();
        }
    }
}
