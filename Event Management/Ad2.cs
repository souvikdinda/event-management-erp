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
    public partial class Ad2 : Form
    {
        SqlConnection cs = new SqlConnection("data source=.;initial catalog=User;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        public Ad2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from Event", cs);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
