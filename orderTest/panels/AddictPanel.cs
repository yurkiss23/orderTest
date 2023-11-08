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
        static private List<addModel> AddList = new List<addModel>();

        private void nameADD_SelectedIndexChanged(object sender, EventArgs e) => isNullPosition(nameADD, meterADD);

        private void meterADD_SelectedIndexChanged(object sender, EventArgs e) => isNullPosition(meterADD, amountADD);

        private void amountADD_TextChanged(object sender, EventArgs e) => isNum(amountADD);

        private void amountADD_Leave(object sender, EventArgs e) => addAddToOrderButton.Enabled = true;

        private void addAddToOrderButton_Click(object sender, EventArgs e)
        {
            //новий рядок
            string[] addADD = { nameADD.Text, meterADD.Text, amountADD.Text };

            //перевірка: заповненість, чи є вже дані в списку, чи збігається марка
            //if (isLast(AddList.Count)) { isMark(addADD); }

            //додаємо позицію в замовлення
            AddList.Add(new(addADD));

            //додаємо рядок в таблицю на формі
            addData.Rows.Add(addADD); addData.Visible = true;

            //очищаэмо поля вибору і введення
            addClear();
        }
    }
}
