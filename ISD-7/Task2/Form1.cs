using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public delegate double Arifm(double x, double y);
    public partial class Form1 : Form
    {
        Arifm Add = (x, y) => { return x + y; };
        Arifm Sub = (x, y) => { return x - y; };
        Arifm Mul = (x, y) => { return x * y; };
        Arifm Div = (x, y) =>
        {
            if (y == 0)
            {
                return double.MinValue;
            }
            return x / y;
        };
        Arifm Equal = null;
        double x = 0;
        double y = 0;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            x = 0;
            y = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button17.Text;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "") { textBox2.Text += '+'; index++; }
            if (textBox1.Text != "")
            {
                if (index == 0)
                {
                    double.TryParse(textBox1.Text, out x);
                    textBox2.Text = textBox1.Text + button11.Text;
                    textBox1.Text = "";
                    index++;
                    Equal = Add;
                }
                else
                {
                    double.TryParse(textBox1.Text, out y);
                    x = Equal(x, y);
                    textBox2.Text = x.ToString() + button11.Text;
                    textBox1.Text = "";
                    Equal = Add;
                }
            }
            Equal = Add;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out y);
            x = Equal(x, y);
            if (x == double.MinValue)
            {
                label1.Text = "Error";
                textBox1.Text = "";
                textBox2.Text = "";
                x = 0;
                y = 0;
            }
            textBox2.Text = x.ToString();
            textBox1.Text = "";
            index = 0;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "") { textBox2.Text += '-'; index++; }

            if (textBox1.Text != "")
            {
                if (index == 0)
                {
                    double.TryParse(textBox1.Text, out x);
                    textBox2.Text = x.ToString() + button12.Text;
                    textBox1.Text = "";
                    index++;
                    Equal = Sub;
                }
                else
                {
                    double.TryParse(textBox1.Text, out y);
                    x = Equal(x, y);
                    textBox2.Text = x.ToString() + button12.Text;
                    textBox1.Text = "";
                    Equal = Sub;
                }
            }
            Equal = Sub;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "") { textBox2.Text += '*'; index++; }

            if (textBox1.Text != "")
            {
                if (index == 0)
                {
                    double.TryParse(textBox1.Text, out x);
                    textBox2.Text = x.ToString() + button13.Text;
                    textBox1.Text = "";
                    index++;
                    Equal = Mul;
                }
                else
                {
                    double.TryParse(textBox1.Text, out y);
                    x = Equal(x, y);
                    textBox2.Text = x.ToString() + button13.Text;
                    textBox1.Text = "";
                    Equal = Mul;
                }
            }
            Equal = Mul;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "") { textBox2.Text += '/'; index++; }

            if (textBox1.Text != "")
            {
                if (index == 0)
                {
                    double.TryParse(textBox1.Text, out x);
                    textBox2.Text = x.ToString() + button14.Text;
                    textBox1.Text = "";
                    index++;
                    Equal = Div;
                }
                else
                {
                    double.TryParse(textBox1.Text, out y);
                    x = Equal(x, y);
                    if (x == double.MinValue)
                    {
                        label1.Text = "Error";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        x = 0;
                        y = 0;
                    }
                    textBox2.Text = x.ToString() + button14.Text;
                    textBox1.Text = "";
                    Equal = Div;
                }
            }
            Equal = Div;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
