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

namespace Event_Management
{
    public partial class Page6_1_ : Form
    {
        int y, total,x;
        SqlConnection cs = new SqlConnection("data source=.;initial catalog=User;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public Page6_1_()
        {
            
            InitializeComponent();
            label8.Hide();
            button4.Hide();
            button3.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Confirm Event Booking?");
            /*Label label8 = new Label();
            Button button3 = new Button();
            Button button4 = new Button();
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            label8.Text = "Confirm Booking?";
            button3.Text = "YES";
            button4.Text = "NO";*/
            button1.Hide();
            label8.Show();
            button3.Show();
            button4.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                label7.Text = "30000";
            }
            else if (comboBox1.SelectedIndex==1)
            {
                label7.Text = "25000";
            }
            else if (comboBox1.SelectedIndex ==2)
            {
                label7.Text = "20000";
            }


            x = Convert.ToInt32(comboBox2.Text.ToString());
            if (comboBox1.SelectedIndex == 0)
            {
                y = 30000;
                total = x * y;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                y = 25000;
                total = x * y;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                y = 20000;
                total = x * y;
            }
            //int z=y;
            label9.Text = Convert.ToString(total);

        }

        public string myval()
        {
                return label9.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {   string bname="COLDPLAY";
            da.InsertCommand = new SqlCommand("insert into Event values(@Bandname,@Date,@Bookingno,@Revenue)", cs);
            da.InsertCommand.Parameters.Add("Bandname", SqlDbType.VarChar).Value = bname;
            da.InsertCommand.Parameters.Add("Date", SqlDbType.VarChar).Value =label1.Text;
            da.InsertCommand.Parameters.Add("Bookingno", SqlDbType.VarChar).Value = comboBox2.Text.ToString();
            da.InsertCommand.Parameters.Add("Revenue", SqlDbType.VarChar).Value = label9.Text;
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
            MessageBox.Show("Event Added");
            Paypage objh = new Paypage(label9.Text);
           // objh.StartPosition = FormStartPosition.CenterParent;
            //objh.ShowDialog(this);
            objh.Show();
            this.Hide();
            
            //objf1.Show();
            //this.Hide();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Hide();
            button4.Hide();
            button3.Hide();
            button1.Show();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            obj.Show();
            this.Hide();
            //this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(comboBox2.Text.ToString());
            if (comboBox1.SelectedIndex == 0)
            {
                y = 30000;
                total = x * y;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                y = 25000;
                total = x * y;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                y=20000;
                total = x * y;
            }
            //int z=y;
            label9.Text = Convert.ToString(total);
        }
    }
}
