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
        static private List<epsModel> EpsList = new List<epsModel>();

        private void markEPS_SelectedIndexChanged(object sender, EventArgs e) => isNullPosition(markEPS, thikEPS);

        private void thikEPS_SelectedIndexChanged(object sender, EventArgs e) => isNullPosition(thikEPS, amountEPS);

        private void amountEPS_TextChanged(object sender, EventArgs e) => isNum(amountEPS);

        private void amountEPS_Leave(object sender, EventArgs e)
        {
            packEPS.Enabled = true; packEPS.Text = ((double.Parse(amountEPS.Text) / div(thikEPS.Text)).ToString()); addEpsToOrderButton.Enabled = true;
        }

        private void addEpsToOrderButton_Click(object sender, EventArgs e)
        {
            //новий рядок
            string[] addEPS = { markEPS.SelectedItem.ToString(), thikEPS.SelectedItem.ToString(), amountEPS.Text, packEPS.Text };

            //перевірка: заповненість, чи є вже дані в списку, чи збігається марка
            if (isLast(EpsList.Count)) { isMark(addEPS); }

            //додаємо eps в замовлення
            EpsList.Add(new(addEPS));

            //додаємо рядок в таблицю на формі
            epsData.Rows.Add(addEPS); epsData.Visible = true;

            //очищаэмо поля вибору і введення
            epsClear();
        }
    }
}
