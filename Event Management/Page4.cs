using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Net.Mail;

namespace Event_Management
{
    public partial class Page4 : Form
    {
        SqlConnection cs = new SqlConnection("data source=.;initial catalog=User;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
       
        public Page4()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("insert into Details values(@USERNAME,@FNAME,@LNAME,@AGE,@EID,@PHNO,@GENDER,@COUNTRY,@STATE,@SQ,@ANSWER,@PASSWORD)", cs);
            da.InsertCommand.Parameters.Add("USERNAME", SqlDbType.VarChar).Value = textBox1.Text;
            da.InsertCommand.Parameters.Add("FNAME", SqlDbType.VarChar).Value = textBox2.Text;
            da.InsertCommand.Parameters.Add("LNAME", SqlDbType.VarChar).Value = textBox3.Text;
            da.InsertCommand.Parameters.Add("AGE", SqlDbType.Int).Value = textBox4.Text;
            da.InsertCommand.Parameters.Add("EID", SqlDbType.VarChar).Value = textBox5.Text;
            da.InsertCommand.Parameters.Add("PHNO", SqlDbType.VarChar).Value = textBox6.Text;
            da.InsertCommand.Parameters.Add("GENDER", SqlDbType.VarChar).Value = textBox7.Text;
            da.InsertCommand.Parameters.Add("COUNTRY", SqlDbType.VarChar).Value = textBox8.Text;
            da.InsertCommand.Parameters.Add("STATE", SqlDbType.VarChar).Value = textBox9.Text;
            da.InsertCommand.Parameters.Add("SQ", SqlDbType.VarChar).Value = comboBox1.Text.ToString();
            da.InsertCommand.Parameters.Add("ANSWER", SqlDbType.VarChar).Value = textBox10.Text;
            da.InsertCommand.Parameters.Add("PASSWORD", SqlDbType.VarChar).Value = textBox11.Text;
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
           
            MessageBox.Show("Successfully Entered");
            string from = "alphaproject36@gmail.com";
            string body = "You have successfully registered with The Generation Of Miracles \nYour Registration Details are as follows:\nUsername : "+textBox1.Text+"\nPassword : "+textBox11.Text;
            string subject = "Registration to The Generation of Miracles";
            string pass = "eventmanagement12345*";
            string smtp12 = "smtp.gmail.com";
            MailMessage mail = new MailMessage(from, textBox5.Text, subject, body);
            SmtpClient client = new SmtpClient(smtp12);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(from, pass);
            client.EnableSsl = true;
            client.Send(mail);
            this.Hide();
            
        }

        private void Page4_Load(object sender, EventArgs e)
        {

        }
    }
}