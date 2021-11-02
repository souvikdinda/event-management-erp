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
    public partial class Paypage : Form
    {
        public Paypage(string message)
        {
            InitializeComponent();
            label3.Text = message;
            //Page6_1_ objf = new Page6_1_();
            //label3.Text = objf.myval();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                label7.Enabled = false;
                textBox7.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label7.Enabled = true;
                textBox7.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label7.Enabled = true;
                textBox7.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Confirmed! Thankyou for booking");
            this.Close();

        }
    }
}
