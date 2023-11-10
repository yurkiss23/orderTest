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
        private string[] addEPS;

        private void markEPS_SelectedIndexChanged(object sender, EventArgs e) => isNullPosition(markEPS, thikEPS);

        private void thikEPS_SelectedIndexChanged(object sender, EventArgs e) => isNullPosition(thikEPS, amountEPS);

        private void amountEPS_TextChanged(object sender, EventArgs e) => isNum((TextBox)sender, new[] { addEpsToOrderButton }, packEPS);

        private void amountEPS_Leave(object sender, EventArgs e) { fillEnable(new Control[] { packEPS, addEpsToOrderButton }, true); calcPack(packEPS); }

        private void addEpsToOrderButton_EnabledChanged(object sender, EventArgs e) => isButtonStateChanged((Button)sender);

        private void addEpsToOrderButton_Click(object sender, EventArgs e)
        {
            //новий рядок
            addEPS = new[] { markEPS.SelectedItem.ToString(), thikEPS.SelectedItem.ToString(), amountEPS.Text, packEPS.Text };

            //перевірка: чи є вже дані в списку, чи збігається марка
            if (isLast(EpsList.Count)) { isMark(addEPS); }

            //додаємо eps в замовлення
            EpsList.Add(new(addEPS)); txtBold(radioEPS);

            //додаємо рядок в таблицю на формі
            epsData.Rows.Add(addEPS); epsData.Visible = true;

            //очищаэмо поля вибору і введення
            epsClear();

            enableButton();
        }
    }
}
