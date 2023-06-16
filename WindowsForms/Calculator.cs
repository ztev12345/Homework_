using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Calculator : Form
    {
        double a, b, c;

        public Calculator()
        {
            InitializeComponent();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a * b;
                textBox3.Text = Convert.ToString(c);
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a / b;
                textBox3.Text = Convert.ToString(c);
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a + b;
                textBox3.Text = Convert.ToString(c);
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a - b;
                textBox3.Text = Convert.ToString(c);
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入數值");
            }
        }

       
    }
}
