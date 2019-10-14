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
            //The try catches detect if anything that isnt a number has been put into the text boxes.

            double s1rt = s1r1 + s1r2;
            label3.Text = "=" + s1rt;
            //This calculates the resistence for the serise circut with 2 resisters.

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
            //The try catches detect if anything that isnt a number has been put into the text boxes.

            double s2rt = s2r1 + s2r2 + s2r3;
            label7.Text = "=" + s2rt;
            //This calculates the resistence for the series circut whith 3 resisters.
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double p1r1, p1r2;

            try
            {
                p1r1 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                p1r1 = 0.0;
            }

            try
            {
                p1r2 = double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                p1r2 = 0.0;
            }
            //The try catches detect if anything that isnt a number has been put into the text boxes.

            double p1rt = 1.0 / (1.0 / p1r1 + 1.0 / p1r2 );
            label10.Text = "=" + p1rt;
            //This calculates the  resistence for the paraller circut with 2 resisters.
        
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double p2r1, p2r2, p2r3;

            try
            {
                p2r1 = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                p2r1 = 0.0;
            }

            try
            {
                p2r2 = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                p2r2 = 0.0;
            }

            try
            {
                p2r3 = double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                p2r3 = 0.0;
            }
            //The try catches detect if anything that isnt a number has been put into the text boxes.

            double p2rt = 1.0 / (1.0 / p2r1 + 1.0 / p2r2 + 1.0 / p2r3);
            label14.Text = "=" + p2rt;
            //this calculates the resistence for the parrallel with 3 resisters.
        }
    }
}
