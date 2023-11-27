﻿using orderTest.models;
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
            //if (isLast(EpsList.Count)) isMark(addEPS);

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

        private void epsDelete_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("справді?", "видалити рядок", MessageBoxButton.OKCancel);

            //рядок з таблиці, який видаляємо
            List<string> removeEPS = new List<string>(); foreach (DataGridViewCell item in epsData.SelectedRows[0].Cells) removeEPS.Add(item.Value.ToString());

            //видаляємо eps із замовлення
            epsModel remove = new epsModel(removeEPS.ToArray()) { };
            for (int i = EpsList.Count-1; i >=0; i--)
            {
                epsModel eps = EpsList[i]; if (eps.Mark == remove.Mark && eps.Thikness == remove.Thikness && eps.Amount == remove.Amount) EpsList.RemoveAt(EpsList.IndexOf(eps));
            }

            //видаляємо рядок з таблиці на формі
            epsData.Rows.Remove(epsData.SelectedRows[0]);

            //
            if (!(EpsList.Count > 0)) { epsDelete.Visible = false; epsDelete.Enabled = false; }
        }
    }
}
