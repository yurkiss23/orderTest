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
        private void selectDefaultItem(ComboBox[] cb) { foreach (ComboBox cbItem in cb) cbItem.SelectedIndex = 0; }

        private void initArrays()
        {
            panels = new[] { headerPanel, epsPanel, addPanel };
            addBut = new[] { addHeadData, addEpsToOrderButton, addAddToOrderButton };
            diffControlArray = new Control[] { numberHead, commentHead, clearHead };
            txtControlArray = new[] { markHead, vehicleHead, addressHead, driverHead };
            ph = new[] { "#", "замовник", "марка", "машина", "адреса", "водій" };
            epsControl = new Control[] { thikEPS, amountEPS, packEPS, addEpsToOrderButton };
        }

        private void panelEnVis(Panel panel) { foreach (Panel p in panels) { p.Enabled = panel.Equals(p) ? true : false; p.Visible = panel.Equals(p) ? true : false; } }

        private void enableButton() { if (hd != null && EpsList.Any() || AddList.Any()) fillEnable(new[] { downToFile }, true); }

        private void txtBold(Control c) => c.Font = new Font(c.Font, c.Font.Style | FontStyle.Bold | FontStyle.Underline);

        private void resetAll() { headClear(txtControlArray.ToList()); epsClear(); addClear(); EpsList.Clear(); AddList.Clear(); downToFile.Text = "вийти"; }

        private void addControls(Control[] ctrls, Form f) { foreach (Control c in ctrls) f.Controls.Add(c); }

        //is...
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

        private void isNum(TextBox tb, Control th, Control tCtrl = null)
        {
            if (tb.Text != "")
            {
                try { int.Parse(tb.Text); if (tCtrl != null) calcPack(new Control[] { th, tb, tCtrl }); }
                catch (Exception)
                {
                    try { double.Parse(tb.Text); if (tCtrl != null) calcPack(new Control[] { th, tb, tCtrl }); }
                    catch (Exception ex) { if (tCtrl != null) MessageBox.Show("потрібно ввести число!", ex.Message.ToString()); tb.SelectAll(); }
                }
            }
        }

        private bool isLast(int count) { if (count > 0) return true; return false; }

        private void isNullPosition(ComboBox a, Control b) => b.Enabled = a.SelectedIndex != 0 ? true : false;

        private void isButtonStateChanged(Button b) => b.FlatStyle = b.Enabled ? FlatStyle.Popup : FlatStyle.System;

        private void isFill(TextBox t, Control[] ctrs, bool state, string ph) { if (!t.Text.Any()) { txt(new List<Control> { t }, new[] { ph }); fillEnable(ctrs, state); } }

        private bool isState(Control[] ctrl) { foreach (Control c in ctrl) { if (c.Enabled) return false; } return true; }

        private int storages() => EpsList.Any() ? (AddList.Any() ? 2 : 1) : 1;

        //fill..
        private void fillEnable(Control[] ctrs, bool state) { foreach (Control c in ctrs) c.Enabled = state; }

        private void fillVisible(Control[] ctrs, bool state) { foreach (Control c in ctrs) c.Visible = state; }

        private void fillPanelProps(Point p, Size s, ComboBox[] cb) { foreach (Panel pn in panels) { pn.Location = p; pn.Size = s; } selectDefaultItem(cb); }

        private void fillCtrlPrs(Control c, string s, int[] prs) { c.Font = fillFont("Calibri", 14); c.Text = s; c.Location = fillPoint(prs[0], prs[1]); c.Size = fillSize(prs[2], prs[3]); }

        private Font fillFont(string s, int x) => new Font(s, x);

        private Point fillPoint(int x, int y) => new Point(x, y);

        private Size fillSize(int a, int b) => new Size(a, b);
    }
}
