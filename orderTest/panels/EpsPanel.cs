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
            epsModel eps = new epsModel(addEPS);

            //перевірка: чи є вже дані в списку, чи збігається марка
            if (isLast(EpsList.Count)) isMark(addEPS);

            //додаємо eps в замовлення
            EpsList.Add(eps); txtBold(radioEPS); radioEPS.ForeColor = Color.DarkGreen;

            //додаємо рядок в таблицю на формі
            epsData.Rows.Add(addEPS); epsData.Visible = true;

            //очищаэмо поля вибору і введення
            epsClear();

            enableButton();

            epsDelete.Visible = true;
            epsDelete.Enabled = true;
        }

        private void epsDelete_EnabledChanged(object sender, EventArgs e)
        {
            foreach (var eps in EpsList)
            {
                System.Windows.Forms.MessageBox.Show(eps.ToString());
            }
        }

        private void epsDelete_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("справді?", "видалити рядок", MessageBoxButton.OKCancel);
            //System.Windows.Forms.MessageBox.Show(epsData.SelectedRows[0].Cells[0].ToString());
            DataGridViewRow removeRow = epsData.SelectedRows[0];
            //string[] removeEPS = new[] { removeRow.Cells[0].Value.ToString(), removeRow.Cells[1].Value.ToString(), removeRow.Cells[2].Value.ToString(), removeRow.Cells[3].Value.ToString() };
            System.Windows.Forms.MessageBox.Show(EpsList.Count.ToString());
            //видаляємо eps із замовлення
            epsModel remove = new epsModel()
            {
                Mark = removeRow.Cells[0].Value.ToString(),
                Thikness = int.Parse(removeRow.Cells[1].Value.ToString()),
                Amount = double.Parse(removeRow.Cells[2].Value.ToString()),
                Pack = int.Parse(removeRow.Cells[3].Value.ToString())
            };

            EpsList.Remove(remove);

            //видаляємо рядок з таблиці на формі
            epsData.Rows.Remove(epsData.SelectedRows[0]);

            //
            epsDelete.Enabled = false;
        }
    }
}
