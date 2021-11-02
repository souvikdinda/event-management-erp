using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management
{
    public partial class Page5 : Form
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page6_1_ objF2 = new Page6_1_();
            objF2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Page6_2_ objF2 = new Page6_2_();
            objF2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bookings not Opened yet. Please try again after few days");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bookings not Opened yet. Please try again after few days");
        }

    }
}
