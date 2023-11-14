using MailKit.Net.Smtp;
using MimeKit;
using orderTest.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
//using System.Net;
//using System.Net.Mail;
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
        static private string path = @"e:\work\dev\orderUST\test.xml";
        static private Panel[] panels;
        static private Button[] addBut;

        public Form1()
        {
            InitializeComponent();

            initArrays();
            fillPanelProps(new Point(0, 0), new Size(753, 400), new[] { markEPS, thikEPS, nameADD, meterADD });
        }

        private void downToFile_EnabledChanged(object sender, EventArgs e) => isButtonStateChanged((Button)sender);

        private void downToFile_Click(object sender, EventArgs e)
        {
            if (downToFile.Text == "вивантажити замовлення")
            {
                //замовлення
                orderModel order = new orderModel(hd, EpsList, AddList);
                MessageBox.Show(order.ToString());
                splitContainer1.Enabled = false; splitContainer1.Visible = false;
                orderLabel.Enabled = false; orderLabel.Visible = false;

                //string orderJson = JsonSerializer.Serialize(hd);
                //Label jsonLabel = new Label(); jsonLabel.Text = orderJson; jsonLabel.Location = new Point(5, 150); jsonLabel.AutoSize = true;
                //Controls.Add(jsonLabel);

                //xml
                XmlSerializer xmlOrder = new XmlSerializer(typeof(orderModel));
                using (FileStream fs = new FileStream(path, FileMode.Create)) xmlOrder.Serialize(fs, order);

                //email
                //var msg = new MimeMessage();
                //msg.Subject = "testOrder";
                //msg.Body = new TextPart("plain") { Text = "test" };
                //msg.From.Add(new MailboxAddress("sender","terranett@ukr.net"));
                //msg.To.Add(new MailboxAddress("receiver","terranet23@gmail.com"));
                ////msg.Attachments.Add(new Attachment(path));
                ////var att=new MimePart()

                //using (var smtp = new SmtpClient())
                //{
                //    smtp.Connect("smtp.ukr.net", 467, false);
                //    smtp.Authenticate("terranett@ukr.net", "1terranet1");
                //    smtp.Send(msg);
                //    smtp.Disconnect(true);
                //}

            } else Close();

            resetAll();

            //File.AppendAllText(path, addEPS + "\n");

        }
    }
}
