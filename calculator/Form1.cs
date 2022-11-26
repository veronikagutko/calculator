using System;
using System.Windows.Forms;

namespace calculator
{

    public partial class Form1 : Form
    {
        public string D; // действие

        public string N1; // первое число

        public bool n2Сheck; //проверка на заполнение второго числа

        public double N2; // второе число

        private bool znak = true;

        private bool Point; //проверка на запятую

        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e) // очистка

        {
            textBox1.Text = "0";

            Point = false;

            znak = true;

            N2 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n2Сheck)
            {
                n2Сheck = false;

                textBox1.Text = "0";
            }

            Button B = (Button)sender;

            if (textBox1.Text == "" && B.Text == ",")
            {
                textBox1.Text = textBox1.Text;
            }
            else if (textBox1.Text == "0")
            {
                if (B.Text == "," && Point == false)
                {
                    textBox1.Text = textBox1.Text + B.Text;

                    Point = true;
                }
                else
                {
                    textBox1.Text = B.Text;
                }
            }
            else
            {
                if (Point == true && B.Text == ",")
                {
                    textBox1.Text = textBox1.Text;
                }
                else if (Point == false && B.Text == ",")
                {
                    textBox1.Text = textBox1.Text + B.Text;

                    Point = true;
                }
                else
                {
                    textBox1.Text = textBox1.Text + B.Text;
                }
            }
        }


        private void button7_Click(object sender, EventArgs e) // +-*/
        {
            Button B = (Button)sender;

            D = B.Text;

            N1 = textBox1.Text;

            znak = true;

            Point = false;

            n2Сheck = true;
        }

        public void button2_Click(object sender, EventArgs e) //кнопка равно
        {
            double dn1, rez;
            
            rez = 0;

            if (N1 == null)
            {
                return;
            }

            dn1 = Convert.ToDouble(N1);

            N2 = Convert.ToDouble(textBox1.Text);

            if (D == "+")
            {
                rez = dn1 + N2;
            }

            if (D == "-")
            {
                rez = dn1 - N2;
            }

            if (D == "×")
            {
                rez = dn1 * N2;
            }

            if (D == "÷")
            {
                rez = dn1 / N2;
            }

            D = "=";

            n2Сheck = true;

            Point = false;

            znak = true;

            N2 = 0;

            textBox1.Text = $"{rez:F2}";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = textBox1.Text + "-";
                znak = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");

                znak = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.KeyChar = (char)0;
                return;
            }
        }
    }
}