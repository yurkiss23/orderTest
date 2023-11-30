using orderTest.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderTest
{
    public partial class Form1 : Form
    {
        static private Form editAddForm;

        private void addClear() { selectDefaultItem(new[] { nameADD, meterADD }); amountADD.Clear(); fillEnable(new Control[] { meterADD, amountADD, addAddToOrderButton }, false); }

        private void fillEditAddForm()
        {
            Label eName = new Label(); fillCtrlPrs(eName, editADD[0].ToString(), new[] { 5, 5, 300, 40 }); eName.TextAlign = ContentAlignment.TopCenter;
            TextBox eAmAdd = new TextBox(); fillCtrlPrs(eAmAdd, editADD[2].ToString(), new[] { 5, 45, 290, 40 });
            //eAmAdd.TextChanged += eAmAdd_TextChanged; eAmAdd.Leave += eAmAdd_Leave;
            Label eMeter = new Label(); fillCtrlPrs(eMeter, editADD[1].ToString(), new[] { 150, 85, 150, 40 });
            Button eSumbit = new Button(); fillCtrlPrs(eSumbit, "записати", new[] { 150, 125, 150, 40 });
            eSumbit.TextAlign = ContentAlignment.TopCenter; eSumbit.Click += eSubmitAdd_Click;

            editAddForm = new Form();
            editAddForm.Text = "редагування додаткових"; editAddForm.Size = fillSize(320, 200); addControls(new Control[] { eName, eAmAdd, eMeter, eSumbit }, editAddForm);
            editAddForm.ShowDialog();
        }

        private void editAddList()
        {
            foreach (DataGridViewRow r in addData.Rows)
            {
                foreach (DataGridViewCell c in r.Cells) editADD.Add(c.Value.ToString()); AddList.Add(new addModel(editADD.ToArray())); editADD.Clear();
            }
        }

        private void eSubmitAdd_Click(object sender, EventArgs e) { editADD[2] = editAddForm.Controls[1].Text; editAddForm.Close(); }
    }
}
