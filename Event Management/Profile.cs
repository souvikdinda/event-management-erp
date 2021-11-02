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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Page6_1_ objh = new Page6_1_();
            objh.StartPosition = FormStartPosition.CenterParent;
            objh.ShowDialog(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page6_2_ objh = new Page6_2_();
            objh.StartPosition = FormStartPosition.CenterParent;
            objh.ShowDialog(this);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            label1.Text ="Welcome "+ Page2.user;
        }
    }
}
