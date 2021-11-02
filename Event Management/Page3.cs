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
    public partial class Page3 : Form
    {
        SqlConnection cs = new SqlConnection("data source=.;initial catalog=User;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public Page3()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Page4 objh = new Page4();
            objh.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            da.SelectCommand = new SqlCommand("select EID,ANSWER,PASSWORD from Details where EID='" + textBox1.Text + "' AND ANSWER='" + textBox2.Text + "' ", cs);
            da.Fill(ds);
            str = ds.Tables[0].Rows[0]["PASSWORD"].ToString();
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Your password is "+str);
                MDIParent1 mp = new MDIParent1();
                mp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}
