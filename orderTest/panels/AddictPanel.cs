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
        static private List<addModel> AddList = new List<addModel>();
        private List<string> removeADD = new List<string>();
        private List<string> editADD = new List<string>();
        private string[] addADD;

        private void nameADD_SelectedIndexChanged(object sender, EventArgs e) => isNullPosition(nameADD, meterADD);

        private void meterADD_SelectedIndexChanged(object sender, EventArgs e) => isNullPosition(meterADD, amountADD);

        private void amountADD_TextChanged(object sender, EventArgs e) => isNum((TextBox)sender, new Control[] { addAddToOrderButton });

        private void amountADD_Leave(object sender, EventArgs e) => addAddToOrderButton.Enabled = true;

        private void addAddToOrderButton_EnabledChanged(object sender, EventArgs e) => isButtonStateChanged((Button)sender);

        private void addAddToOrderButton_Click(object sender, EventArgs e)
        {
            //новий рядок
            addADD = new[] { nameADD.Text, meterADD.Text, amountADD.Text };

            //додаємо позицію в замовлення
            AddList.Add(new(addADD)); txtBold(radioAdd); radioAdd.ForeColor = Color.DarkGreen;

            //додаємо рядок в таблицю на формі
            addData.Rows.Add(addADD); addData.Visible = true;

            //очищаэмо поля вибору і введення
            addClear(); enableButton();

            //
            fillEnable(new Button[] { addDelete, addEdit }, true); fillVisible(new Button[] { addDelete, addEdit }, true);
            //addData.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
        }

        private void addDelete_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("справді видалити?", "видалити рядок", MessageBoxButton.OKCancel);

            //рядок з таблиці, який видаляємо
            foreach (DataGridViewCell item in addData.SelectedRows[0].Cells) removeADD.Add(item.Value.ToString());

            //видаляємо eps із замовлення
            addModel remove = new addModel(removeADD.ToArray()) { }; AddList.RemoveAll(a => a.Name == remove.Name && a.AmAdd == remove.AmAdd);

            //видаляємо рядок з таблиці на формі
            addData.Rows.Remove(addData.SelectedRows[0]);

            //
            if (!(AddList.Count > 0)) { addDelete.Visible = false; addDelete.Enabled = false; }
        }

        private void addEdit_Click(object sender, EventArgs e)
        {
            //рядок з таблиці, який редагуємо
            editADD.Clear(); foreach (DataGridViewCell item in addData.SelectedRows[0].Cells) editADD.Add(item.Value.ToString());

            //форма для редагування
            fillEditAddForm();

            //редагуємо рядок в таблиці на формі
            foreach (DataGridViewCell item in addData.SelectedRows[0].Cells) item.Value = editADD[addData.SelectedRows[0].Cells.IndexOf(item)];

            //перезаповнюємо AddList
            AddList.Clear(); editFoodsList(addData);

            //
            if (!(AddList.Count > 0)) { addEdit.Visible = false; addEdit.Enabled = false; }
        }
    }
}
