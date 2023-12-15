using orderTest.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace orderTest
{
    public partial class Form1 : Form
    {
        static private string path;
        static private Panel[] panels;
        static private Button[] addBut;

        public Form1()
        {
            InitializeComponent();

            initArrays(); fillPanelProps(new Point(0, 0), new Size(753, 400), new[] { markEPS, thikEPS, nameADD, meterADD });
        }

        private void downToFile_EnabledChanged(object sender, EventArgs e) => isButtonStateChanged((Button)sender);

        private void downToFile_Click(object sender, EventArgs e)
        {
            if (downToFile.Text == "вивантажити замовлення")
            {
                //замовлення
                orderModel order = new orderModel(hd, storages(), EpsList, AddList);
                fillEnable([splitContainer1, orderLabel], false); fillVisible([splitContainer1, orderLabel], false);

                //вибір path
                SaveFileDialog sDialog = new SaveFileDialog(); sDialog.Filter = "xml files(*.xml)|*.xml"; if (sDialog.ShowDialog() == DialogResult.OK) path = sDialog.FileName; else return;

                //xml
                XmlSerializer xmlOrder = new XmlSerializer(typeof(orderModel)); using (FileStream fs = new FileStream(path, FileMode.Create)) xmlOrder.Serialize(fs, order);

            } else Close();

            resetAll();
        }
    }
}
