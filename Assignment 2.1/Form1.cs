using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double s1r1, s1r2;

            try
            {
                s1r1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                s1r1 = 0.0;
            }

            try
            {
                s1r2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                s1r2 = 0.0;
            }
            double s1rt = s1r1 + s1r2;
            label3.Text = "=" + s1rt;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double s2r1, s2r2, s2r3;

            try
            {
                s2r1 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                    s2r1 = 0.0;
            }

            try
            {
                s2r2 = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                    s2r2 = 0.0;
            }

            try
            {
                s2r3 = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                s2r3 = 0.0;
            }

            double s2rt = s2r1 + s2r2 + s2r3;
            label7.Text = "=" + s2rt;
        }
    }
}
