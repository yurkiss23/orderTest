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
        static private string[] ph;
        static private Form addClientForm;
        static private List<string> cltsList;
        static private List<string> addrsList;

        private void txt(List<Control> list, string[] ph) { foreach (TextBox t in list) t.Text = "---" + ph[list.IndexOf(t)] + "---"; }

        private bool isPH(string ph) => ph.Contains("---") ? true : false;

        private void clearText(TextBox tb) { if (isPH(tb.Text)) tb.Clear(); }

        private void headClear(List<Control> cl)
        {
            List<Control> tmpCtrTxt = new List<Control> { numberHead, clientHead, addressHead }.Concat(cl).ToList();
            dateHead.ResetText(); txt(tmpCtrTxt, ph); fillEnable(tmpCtrTxt.Concat(new List<Control> { clearHead, addHeadData }).ToArray(), false);
        }

        private string toStr(List<string> list,string t) { string ts = "1." + t; foreach (string s in list) { int i = list.IndexOf(s); ts += (i++).ToString() + "." + s; } return ts; }

        private void fillManyCltsForm()
        {
            //Label eMark = new Label(); fillCtrlPrs(eMark, editEPS[0].ToString(), new[] { 5, 5, 300, 40 }); eMark.TextAlign = ContentAlignment.TopCenter;
            TextBox addClt = new TextBox(); fillCtrlPrs(addClt, "---замовник---", [5, 10, 350, 40]); addClt.TextAlign = HorizontalAlignment.Center;
            addClt.TextChanged += AddClt_TextChanged; addClt.Leave += AddClt_Leave;
            TextBox addAddr = new TextBox(); fillCtrlPrs(addAddr, "---адреса---", [5, 50, 350, 40]); addAddr.TextAlign = HorizontalAlignment.Center;
            //Label ePark = new Label(); fillCtrlPrs(ePark, editEPS[3].ToString(), new[] { 5, 125, 150, 40 });
            Button addClient = new Button(); fillCtrlPrs(addClient, "додати вигрузку", [5, 100, 150, 40]);
            addClient.TextAlign = ContentAlignment.TopCenter; addClient.Click += addClient_Click;
            Button addCltSub = new Button(); fillCtrlPrs(addCltSub, "додати вигрузку/вийти", [200, 100, 150, 40]);
            addCltSub.TextAlign = ContentAlignment.TopCenter; addCltSub.Click += AddCltSub_Click;
            Button cncl = new Button(); fillCtrlPrs(cncl, "скасувати", [5, 150, 350, 40]);
            cncl.TextAlign = ContentAlignment.TopCenter; cncl.Click += cncl_Click;

            //cltsList = new List<string>();

            addClientForm = new Form();
            addClientForm.Text = "додавання вигрузки"; addClientForm.Size = fillSize(420, 210); addControls([addClt, addAddr, addClient, addCltSub, cncl], addClientForm);
            addClientForm.ShowDialog();
        }

        private void addItem(List<string>[]array) { foreach (List<string> item in array) item.Add(addClientForm.Controls[array.ToList().IndexOf(item)].Text); }

        private void addClient_Click(object sender, EventArgs e) { addItem([cltsList, addrsList]); clients++; }

        private void AddCltSub_Click(object sender, EventArgs e) { addItem([cltsList, addrsList]); clients++; addClientForm.Close(); }

        private void cncl_Click(object sender, EventArgs e) => addClientForm.Close();

        private void AddClt_Leave(object sender, EventArgs e)
        {
            
        }

        private void AddClt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
