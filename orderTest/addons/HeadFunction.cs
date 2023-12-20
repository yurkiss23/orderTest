using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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

        private string toStr(List<string> list, string t) { string ts = "1." + t; int i = 2; foreach (string s in list) { ts += "|" + i.ToString() + "." + s; i++; } return ts; }

        private void fillManyCltsForm()
        {
            TextBox addClt = new TextBox(); fillCtrlPrs(addClt, "---замовник---", [5, 10, 350, 40]); addClt.TextAlign = HorizontalAlignment.Center;
            addClt.Enter += AddClt_Enter; addClt.TextChanged += AddClt_TextChanged; addClt.Leave += AddClt_Leave;
            TextBox addAddr = new TextBox(); fillCtrlPrs(addAddr, "---адреса---", [5, 45, 350, 40]); addAddr.TextAlign = HorizontalAlignment.Center;
            addAddr.Enabled = false; addAddr.Enter += AddAddr_Enter; addAddr.TextChanged += AddAddr_TextChanged; addAddr.Leave += AddAddr_Leave;
            Button addClient = new Button(); fillCtrlPrs(addClient, "додати ще", [5, 95, 160, 40]); addClient.Enabled = false;
            addClient.TextAlign = ContentAlignment.TopCenter; addClient.Click += addClient_Click;
            Button addCltSub = new Button(); fillCtrlPrs(addCltSub, "додати і вийти", [195, 95, 160, 40]); addCltSub.Enabled = false;
            addCltSub.TextAlign = ContentAlignment.TopCenter; addCltSub.Click += AddCltSub_Click;
            Button cncl = new Button(); fillCtrlPrs(cncl, "скасувати", [5, 140, 350, 40]);
            cncl.TextAlign = ContentAlignment.TopCenter; cncl.Click += cncl_Click;

            cltsList = new List<string>(); addrsList = new List<string>();

            addClientForm = new Form();
            addClientForm.Text = "додавання вигрузки"; addClientForm.Size = fillSize(380, 230); addControls([addClt, addAddr, addClient, addCltSub, cncl], addClientForm);
            addClientForm.ShowDialog();
        }

        private void AddClt_Enter(object sender, EventArgs e) => clearText((TextBox)addClientForm.Controls[0]);

        private void AddClt_TextChanged(object sender, EventArgs e) => fillEnable(addClientForm.Controls[1], true); //при зміні вмикається адреса

        private void AddClt_Leave(object sender, EventArgs e) => isFill((TextBox)sender, [addClientForm.Controls[2], addClientForm.Controls[3]], true, "замовник");

        private void AddAddr_Enter(object sender, EventArgs e) => clearText((TextBox)addClientForm.Controls[1]);

        private void AddAddr_TextChanged(object sender, EventArgs e) => fillEnable([addClientForm.Controls[2], addClientForm.Controls[3]], true);

        private void AddAddr_Leave(object sender, EventArgs e) => isFill((TextBox)sender, [addClientForm.Controls[2], addClientForm.Controls[3]], true, "адреса");

        private void addClient_Click(object sender, EventArgs e)
        {
            addItems([cltsList, addrsList]); clients++; txt(new List<Control> { addClientForm.Controls[0], addClientForm.Controls[1] }, ["замовник", "адреса"]);
            fillEnable([addClientForm.Controls[1], addClientForm.Controls[2], addClientForm.Controls[3]], false); addClientForm.Controls[0].Focus();
        }

        private void AddCltSub_Click(object sender, EventArgs e) { addItems([cltsList, addrsList]); clients++; addClientForm.Close(); }

        private void cncl_Click(object sender, EventArgs e) => addClientForm.Close();
    }
}
