using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "1";
            else
                textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "2";
            else
                textBox1.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "3";
            else
                textBox1.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "4";
            else
                textBox1.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "5";
            else
                textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "6";
            else
                textBox1.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "7";
            else
                textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "8";
            else
                textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "9";
            else
                textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "0";
            else
                textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == null || textBox1.Text == "o")
                textBox1.Text = "0.";
            else
                textBox1.Text += ".";
        }
        char islem;
        double sayi1, sayi2;
        private void button13_Click(object sender, EventArgs e)
        {
            islem = '+';
            sayi1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = '-';
            sayi1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            islem = '*';
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            islem = '/';
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
        }
        double sonuc;
        private void button21_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text);
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    textBox1.Text = sonuc.ToString();
                    break;

                case '-':
                    sonuc = sayi1 - sayi2;
                    textBox1.Text = sonuc.ToString();
                    break;

                case '*':
                    sonuc = sayi1 * sayi2;
                    textBox1.Text = sonuc.ToString();
                    break;

                case '/':
                    if (sayi1 == 0)
                        textBox1.Text = "sayı bölünemez";
                    else
                    {
                        sonuc = sayi1 / sayi2;
                        textBox1.Text = sonuc.ToString();
                    }
                    break;
                case 'p':
                    sonuc = Math.Pow(sayi1, sayi2);
                    textBox1.Text = sonuc.ToString();
                    break;


            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Sqrt(sayi1);
            textBox1.Text = sonuc.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Floor(sayi1);
            textBox1.Text = sonuc.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Ceiling(sayi1);
            textBox1.Text = sonuc.ToString();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            islem = 'p';
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Sin(sayi1);
            textBox1.Text = sonuc.ToString();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Cos(sayi1);
            textBox1.Text = sonuc.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Abs(sayi1);
            textBox1.Text = sonuc.ToString();
        }
    }
}
