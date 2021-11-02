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
    
    public partial class Page2 : Form
    {
        SqlConnection cs = new SqlConnection("data source=.;initial catalog=User;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public static string user;
        public Page2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select USERNAME,PASSWORD from Details where USERNAME='"+textBox1.Text+"' AND PASSWORD='"+textBox2.Text+"'", cs);
            user = textBox1.Text;
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count>0)
            {
                Form2 objh= new Form2();
                objh.StartPosition = FormStartPosition.CenterParent;
                //objh.Show();
                objh.ShowDialog(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Page3 objh = new Page3();
            objh.StartPosition = FormStartPosition.CenterParent;
            objh.ShowDialog(this);
            this.Hide();
        }

        private void Page2_Load(object sender, EventArgs e)
        {
            
        }
    }
    }
