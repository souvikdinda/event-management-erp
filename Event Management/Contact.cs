using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

namespace Event_Management
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = "alphaproject36@gmail.com";
            string body = "Thank You for contacting Us";
            string subject = "Contact To The Generation Of Miracle";
            string pass= "eventmanagement12345*";
            string smtp12 = "smtp.gmail.com";
            MailMessage mail = new MailMessage(from, textBox2.Text, subject, body);
            SmtpClient client = new SmtpClient(smtp12);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(from , pass);
            client.EnableSsl = true;
            client.Send(mail);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }
    }
}

