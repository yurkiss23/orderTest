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

        private void calcPack(TextBox t) => packEPS.Text = (double.Parse(amountEPS.Text) / (thikEPS.Text.Equals("8") ? 0.32 : 0.3)).ToString();

        private void isMark(string[] row) => row[0] = EpsList.Last().Mark.Equals(markEPS.Text) ? "" : row[0];

        private void epsClear() { selectDefaultItem(new[] { markEPS, thikEPS }); amountEPS.Clear(); packEPS.Clear(); fillEnable(epsControl, false); }

        private void fillEditEpsForm(Form f)
        {
            Label eMark = new Label();
            eMark.Font = new Font("Calibri", 14); eMark.Text = editEPS[0].ToString(); eMark.TextAlign = ContentAlignment.TopCenter;
            eMark.Location = new System.Drawing.Point(5, 5); eMark.Size = new System.Drawing.Size(300, 40);

            TextBox eThik = new TextBox();
            eThik.Font = new Font("Calibri", 14); eThik.Text = editEPS[1].ToString();
            eThik.Location = new System.Drawing.Point(5, 50); eThik.Size = new System.Drawing.Size(290, 40);

            //Form editEpsForm = new Form(); 
            f.Text = "редагування EPS"; f.Size = new System.Drawing.Size(320, 200);
            f.Controls.Add(eMark); f.Controls.Add(eThik);
            f.ShowDialog();
        }
    }
}
