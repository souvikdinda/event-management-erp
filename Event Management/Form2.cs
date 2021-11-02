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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             progressBar1.Value = 0;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if(progressBar1.Value>=30)
            { label1.Text = "Preparing Instruments"; 
            }
            if(progressBar1.Value>=50)
            {
                label1.Text = "Preparing Stage";
            }
            if (progressBar1.Value >= 70)
            {
                label1.Text = "Starting Concert";
            }
            if(progressBar1.Value==100)
            {
                timer1.Enabled = false;
                Profile objh = new Profile();
                objh.Show();
                //objh.StartPosition = FormStartPosition.CenterParent;
                //objh.ShowDialog(this);
                this.Hide();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
