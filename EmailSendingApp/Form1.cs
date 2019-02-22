using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace EmailSendingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(txt_smtpserver.Text)
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(Convert.ToString(txt_from), Convert.ToString(txt_password)),
                UseDefaultCredentials = false

        };
            message.From = new MailAddress(txt_from.Text);
            message.To.Add(txt_to.Text);
            message.Subject = txt_subject.Text;
            message.Body = richTextBox1.Text;
            SmtpServer.Send(message);
        }
    }
}
