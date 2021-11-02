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
    public partial class Page7 : Form
    {
        SqlConnection cs = new SqlConnection("data source=.;initial catalog=User;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public Page7()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select Username,Password from Signies where Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'", cs);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ad2 objh = new Ad2();
                objh.Show();
                //objh.StartPosition = FormStartPosition.CenterParent;
                //objh.ShowDialog(this);
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
            
        }
    }
}