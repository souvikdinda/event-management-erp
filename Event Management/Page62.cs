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
    public partial class Page6_2_ : Form
    {
        public static String user2;
        SqlConnection cs = new SqlConnection("data source=.;initial catalog=User;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        int x, y, total;
        public Page6_2_()
        {
            InitializeComponent();
            label8.Hide();
            button4.Hide();
            button3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            label8.Show();
            button3.Show();
            button4.Show();
        }

        private void Page6_2__Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bname = "LINKIN PARK";
            da.InsertCommand = new SqlCommand("insert into Event values(@Bandname,@Date,@Bookingno,@Revenue)", cs);
            da.InsertCommand.Parameters.Add("Bandname", SqlDbType.VarChar).Value = bname;
            da.InsertCommand.Parameters.Add("Date", SqlDbType.VarChar).Value = label1.Text;
            da.InsertCommand.Parameters.Add("Bookingno", SqlDbType.VarChar).Value = comboBox2.Text.ToString();
            da.InsertCommand.Parameters.Add("Revenue", SqlDbType.VarChar).Value = label9.Text;
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
            string mes = label10.Text;
            Paypage objf1 = new Paypage(mes);
            objf1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label7.Text = "30000";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label7.Text = "25000";
            }
            else if (comboBox1.SelectedIndex == 2)
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
            label10.Text = Convert.ToString(total);
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
