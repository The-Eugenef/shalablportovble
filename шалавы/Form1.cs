using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace шалавы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float x, y;
        int count;
        bool znak = true;

        private void button10_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (textBox1.Text=="0")
                textBox1.Text=B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(znak==true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if(znak==false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    y = x + float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;

                case 2:
                    y = x - float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;

                case 3:
                    y = x * float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;

                case 4:
                    y = x / float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;

                case 5:
                    y = (float)Math.Pow(x,float.Parse(textBox1.Text));
                    textBox1.Text = y.ToString();
                    break;

                case 6:
                    y = (float)Math.Exp(x);
                    textBox1.Text = y.ToString();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Purple;
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = x.ToString() + "+";
            znak = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = x.ToString() + "-";
            znak = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = x.ToString() + "*";
            znak = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = x.ToString() + "/";
            znak = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            label1.Text = "e^" + x.ToString();
            znak = true;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = x.ToString() + "^";
            znak = true;
        }



        private void button6_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }

        }
    }
}