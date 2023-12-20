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
        List<string> editRow = new List<string>();

        private void selectDefaultItem(ComboBox[] cb) { foreach (ComboBox cbItem in cb) cbItem.SelectedIndex = 0; }

        private void initArrays()
        {
            panels = new[] { headerPanel, epsPanel, addPanel };
            addBut = new[] { addHeadData, addEpsToOrderButton, addAddToOrderButton };
            diffControlArray = new Control[] { numberHead, commentHead, clearHead };
            txtControlArray = new[] { markHead, vehicleHead, driverHead };
            addCltControlArray = new Control[] { dateHead, numberHead, markHead, vehicleHead, driverHead };
            ph = new[] { "#", "замовник", "адреса", "марка", "машина", "водій" };
            epsControl = new Control[] { thikEPS, amountEPS, packEPS, addEpsToOrderButton };
        }

        private void panelEnVis(Panel panel) { foreach (Panel p in panels) { p.Enabled = panel.Equals(p) ? true : false; p.Visible = panel.Equals(p) ? true : false; } }

        private void enableButton() { if (hd != null && (EpsList.Any() || AddList.Any())) fillEnable(new[] { downToFile }, true); }

        private void txtBold(Control c) => c.Font = new Font(c.Font, c.Font.Style | FontStyle.Bold | FontStyle.Underline);

        private void resetAll() { headClear(txtControlArray.ToList()); epsClear(); addClear(); EpsList.Clear(); AddList.Clear(); downToFile.Text = "saved! \nвийти"; }

        //add..
        private void addControls(Control[] ctrls, Form f) { foreach (Control c in ctrls) f.Controls.Add(c); }

        private void addItems(List<string>[] array) { foreach (List<string> item in array) item.Add(addClientForm.Controls[array.ToList().IndexOf(item)].Text); }

        private void addItems() { fillEnVis(cList, clients == 1 ? false : true); for (int i = 1; i <= clients; i++) cList.Items.Add(i); selectDefaultItem([cList]); }

        //edit..
        private void editFoodsList(DataGridView data)
        {
            foreach (DataGridViewRow r in data.Rows)
            {
                foreach (DataGridViewCell c in r.Cells) editRow.Add(c.Value.ToString());
                if (r.Cells.Count > 3) EpsList.Add(new epsModel(editRow.ToArray())); else AddList.Add(new addModel(editRow.ToArray()));
                editRow.Clear();
            }
        }

        //is...
        private void isOne() { }

        private void isNum(TextBox tb, Control[] ctrl, TextBox tCtrl = null)
        {
            if (tb.Text != "")
            {
                try { int.Parse(tb.Text); if (tCtrl != null) calcPack(tCtrl); fillEnable(ctrl, true); }
                catch (Exception)
                {
                    try { double.Parse(tb.Text); if (tCtrl != null) calcPack(tCtrl); fillEnable(ctrl, true); }
                    catch (Exception ex) { if (tCtrl != null) tCtrl.Clear(); fillEnable(ctrl, false); MessageBox.Show("потрібно ввести число!", ex.Message.ToString()); tb.SelectAll(); }
                }
            }
        }

        private void isNum(TextBox tb, Control tCtrl = null)
        {
            if (tb.Text != "")
            {
                try { int.Parse(tb.Text); if (tCtrl != null) calcPack(editEpsForm); }
                catch (Exception)
                {
                    try { double.Parse(tb.Text); if (tCtrl != null) calcPack(editEpsForm); }
                    catch (Exception ex) { if (tCtrl != null) MessageBox.Show("потрібно ввести число!", ex.Message.ToString()); tb.SelectAll(); }
                }
            }
        }

        private bool isLast(int count) { if (count > 0) return true; return false; }

        private void isNullPosition(ComboBox a, Control b) => b.Enabled = a.SelectedIndex == 0 || a.Text == " -" || a.Text == "-|||-" ? false : true;

        private void isButtonStateChanged(Button b) => b.FlatStyle = b.Enabled ? FlatStyle.Popup : FlatStyle.System;

        private void isFill(TextBox t, Control[] ctrs, bool state, string ph) { if (!t.Text.Any()) { txt(new List<Control> { t }, [ph]); fillEnable(ctrs, state); } }

        private bool isState(Control[] ctrl) { foreach (Control c in ctrl) { if (c.Enabled) return false; } return true; }

        private int storages() => EpsList.Any() ? (AddList.Any() ? 2 : 1) : 1;

        //fill..
        private void fillEnable(Control[] ctrs, bool state) { foreach (Control c in ctrs) c.Enabled = state; }

        private void fillEnable(Control c, bool state) => c.Enabled = state;

        private void fillVisible(Control[] ctrs, bool state) { foreach (Control c in ctrs) c.Visible = state; }

        private void fillEnVis(Control[] ctrs, bool state) { foreach (Control c in ctrs) { c.Enabled = state; c.Visible = state; } }

        private void fillEnVis(Control c, bool state) { c.Enabled = state; c.Visible = state; }

        private void fillPanelProps(Point p, Size s, ComboBox[] cb) { foreach (Panel pn in panels) { pn.Location = p; pn.Size = s; } selectDefaultItem(cb); }

        private void fillCtrlPrs(Control c, string s, int[] prs) { c.Font = fillFont("Calibri", 14); c.Text = s; c.Location = fillPoint(prs[0], prs[1]); c.Size = fillSize(prs[2], prs[3]); }

        private Font fillFont(string s, int x) => new Font(s, x);

        private Point fillPoint(int x, int y) => new Point(x, y);

        private Size fillSize(int a, int b) => new Size(a, b);
    }
}
