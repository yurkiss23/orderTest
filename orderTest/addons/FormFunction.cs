using orderTest.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace orderTest
{
    public partial class Form1 : Form
    {
        private void downOrder()
        {
            //замовлення
            orderModel order = new orderModel(hd, storages(), EpsList, AddList);
            fillEnable([splitContainer1, orderLabel], false); fillVisible([splitContainer1, orderLabel], false);

            //вибір path
            SaveFileDialog sDialog = new SaveFileDialog(); sDialog.Filter = "xml files(*.xml)|*.xml"; if (sDialog.ShowDialog() == DialogResult.OK) path = sDialog.FileName; else return;

            //xml
            XmlSerializer xmlOrder = new XmlSerializer(typeof(orderModel)); using (FileStream fs = new FileStream(path, FileMode.Create)) xmlOrder.Serialize(fs, order);
        }

        private void fClear() { }

    }
}
