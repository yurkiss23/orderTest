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
        static private Control[] epsControl;
        static private Form editEpsForm;

        private void calcPack(Control t) => t.Text = (double.Parse(amountEPS.Text) / (thikEPS.Text.Equals("8") ? 0.32 : 0.3)).ToString();

        private void calcPack(Form f) => f.Controls[3].Text = (double.Parse(f.Controls[2].Text) / (f.Controls[1].Text.Equals("8") ? 0.32 : 0.3)).ToString();

        private void isMark(string[] row) => row[0] = EpsList.Last().Mark.Equals(markEPS.Text) ? "" : row[0];

        private void epsClear() { selectDefaultItem(new[] { markEPS, thikEPS }); amountEPS.Clear(); packEPS.Clear(); fillEnable(epsControl, false); }

        private void fillEditEpsForm()
        {
            Label eMark = new Label(); fillCtrlPrs(eMark, editEPS[0].ToString(), new[] { 5, 5, 300, 40 }); eMark.TextAlign = ContentAlignment.TopCenter;
            TextBox eThik = new TextBox(); fillCtrlPrs(eThik, editEPS[1].ToString(), new[] { 5, 45, 290, 40 });
            TextBox eAmount = new TextBox(); fillCtrlPrs(eAmount, editEPS[2].ToString(), new[] { 5, 85, 290, 40 });
            eAmount.TextChanged += eAmount_TextChanged; eAmount.Leave += eAmount_Leave;
            Label ePark = new Label(); fillCtrlPrs(ePark, editEPS[3].ToString(), new[] { 5, 125, 150, 40 });
            Button eSumbit = new Button(); fillCtrlPrs(eSumbit, "записати", new[] { 150, 125, 150, 40 });
            eSumbit.TextAlign = ContentAlignment.TopCenter; eSumbit.Click += eSubmit_Click;

            editEpsForm = new Form();
            editEpsForm.Text = "редагування EPS"; editEpsForm.Size = fillSize(320, 200); addControls(new Control[] { eMark, eThik, eAmount, ePark, eSumbit }, editEpsForm);
            editEpsForm.ShowDialog();
        }

        private void editEpsList()
        {
            foreach (DataGridViewRow r in epsData.Rows)
            {
                foreach (DataGridViewCell c in r.Cells) editEPS.Add(c.Value.ToString()); EpsList.Add(new epsModel(editEPS.ToArray())); editEPS.Clear();
            }
        }

        private void eAmount_TextChanged(object sender, EventArgs e) => isNum((TextBox)sender, editEpsForm.Controls[3]);

        private void eAmount_Leave(object sender, EventArgs e) => calcPack(editEpsForm);

        private void eSubmit_Click(object sender, EventArgs e) { for (int i = 1; i < 4; i++) editEPS[i] = editEpsForm.Controls[i].Text; editEpsForm.Close(); }
    }
}
