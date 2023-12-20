using orderTest.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1 : Form
    {
        private List<epsModel> EpsList = new List<epsModel>();
        private List<string> removeEPS = new List<string>();
        private List<string> editEPS = new List<string>();
        private List<int> epsCltInd = new List<int>();
        private string[] addEPS;

        private void markEPS_SelectedIndexChanged(object sender, EventArgs e) => isNullPosition(markEPS, thikEPS);

        private void thikEPS_SelectedIndexChanged(object sender, EventArgs e) => isNullPosition(thikEPS, amountEPS);

        private void amountEPS_TextChanged(object sender, EventArgs e) => isNum((TextBox)sender, new[] { addEpsToOrderButton }, packEPS);

        private void amountEPS_Leave(object sender, EventArgs e) { fillEnable(new Control[] { packEPS, addEpsToOrderButton }, true); calcPack(packEPS); }

        private void addEpsToOrderButton_EnabledChanged(object sender, EventArgs e) => isButtonStateChanged((Button)sender);

        private void addEpsToOrderButton_Click(object sender, EventArgs e)
        {
            //новий рядок
            addEPS = [markEPS.SelectedItem.ToString(), thikEPS.SelectedItem.ToString(), amountEPS.Text, packEPS.Text];
            epsModel eps = new epsModel(addEPS);

            //додаємо eps в замовлення
            EpsList.Add(eps); txtBold(radioEPS); radioEPS.ForeColor = Color.DarkGreen; if (clients > 1) epsCltInd.Add(cList.SelectedIndex);

            //додаємо рядок в таблицю на формі
            epsData.Rows.Add(addEPS); epsData.Visible = true;

            //очищаэмо поля вибору і введення
            epsClear(); enableButton();

            //
            fillEnVis([epsDelete, epsEdit], true);
        }

        private void epsDelete_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("справді видалити?", "видалити рядок", MessageBoxButton.OKCancel);

            //рядок з таблиці, який видаляємо
            foreach (DataGridViewCell item in epsData.SelectedRows[0].Cells) removeEPS.Add(item.Value.ToString());

            //видаляємо eps із замовлення
            epsModel remove = new epsModel(removeEPS.ToArray()) { }; int i = EpsList.FindIndex(e => e.Mark == remove.Mark && e.Thikness == remove.Thikness && e.Amount == remove.Amount);
            EpsList.RemoveAt(i);
            if (clients > 1) epsCltInd.RemoveAt(i);
            //EpsList.RemoveAll(e => e.Mark == remove.Mark && e.Thikness == remove.Thikness && e.Amount == remove.Amount);

            //видаляємо рядок з таблиці на формі
            epsData.Rows.Remove(epsData.SelectedRows[0]);

            //
            if (!(EpsList.Count > 0)) fillEnVis(epsDelete, false);
        }

        private void epsEdit_Click(object sender, EventArgs e)
        {
            //рядок з таблиці, який редагуємо
            foreach (DataGridViewCell item in epsData.SelectedRows[0].Cells) editEPS.Add(item.Value.ToString());

            //форма для редагування
            fillEditEpsForm();

            //редагуємо рядок в таблиці на формі
            foreach (DataGridViewCell item in epsData.SelectedRows[0].Cells) item.Value = editEPS[epsData.SelectedRows[0].Cells.IndexOf(item)];

            //перезаповнюємо EpsList
            EpsList.Clear(); editFoodsList(epsData);

            //
            if (!(EpsList.Count > 0)) fillEnVis(epsEdit, false);
        }
    }
}
