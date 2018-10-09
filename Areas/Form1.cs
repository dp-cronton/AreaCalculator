using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox2.Hide();
            textBox3.Hide();
            button2.Hide();
            label1.Hide();
            textBox1.Hide();
            label2.Hide();
            button1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(textBox1.Text);
                double A = Math.PI * r * r;
                label2.Text = A.ToString();
            }
            catch
            {
                label2.Text = "N/A";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double b = Convert.ToDouble(textBox2.Text);
                double h = Convert.ToDouble(textBox3.Text);
                double A = b * h;
                label5.Text = A.ToString();
            }
            catch
            {
                label5.Text = "N/A";
            }
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox2.Hide();
            textBox3.Hide();
            button2.Hide();

            label1.Show();
            textBox1.Show();
            label2.Show();
            button1.Show();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Hide();
            textBox1.Hide();
            label2.Hide();
            button1.Hide();

            label3.Show();
            label4.Show();
            label5.Show();
            textBox2.Show();
            textBox3.Show();
            button2.Show();

            
        }
    }
}
