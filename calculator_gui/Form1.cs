using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click("1");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            click("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            click("3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            click("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            click("5");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            click("6");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            click("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            click("8");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            click("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            click("0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            click("+");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            click("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            click("*");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            click("/");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string textt = textBox1.Text;
            calculate(textBox1.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        public void close()
        {
            this.Close();
        }

        public void click(string num)
        {
            textBox1.Text += num;
        }

        public void calculate(string content)
        {

            List<string> chars = new List<string> { };


            string operator1 = "";
            List<string> operators = new List<string> { };
            List<string> firstNum = new List<string> { };
            List<string> secondNum = new List<string> { };

            for (int i = 0; i < content.Length; i++)
            {
                char c = content[i];
                chars.Add(Convert.ToString(c));
            }

            for (int i = 0; i <= (chars.Count) - 1; i++)
            {
                if (chars[i] == "+" || chars[i] == "-" || chars[i] == "*" || chars[i] == "/")
                {
                    operators.Add(chars[i]);
                }

            }

            int operatorLength = operators.Count;

            if (operatorLength > 1)
            {
                textBox1.Text = "Must have only one operator";
            }
            else
            {

                for (int i = 0; i <= (chars.Count) - 1; i++)
                {

                    if (chars[i] == "+" || chars[i] == "-" || chars[i] == "*" || chars[i] == "/")
                    {
                        break;
                    }
                    else
                    {
                        firstNum.Add(chars[i]);
                    }
                }

                for (int i = (chars.Count) - 1; i >= 0; i--)
                {
                    if (chars[i] == "+" || chars[i] == "-" || chars[i] == "*" || chars[i] == "/")
                    {
                        break;
                    }
                    else
                    {
                        secondNum.Insert(0, chars[i]);
                    }

                }

                for (int i = 0; i <= (chars.Count) - 1; i++)
                {
                    if (chars[i] != "0" && chars[i] != "1" && chars[i] != "2" && chars[i] != "3" && chars[i] != "4" && chars[i] != "5" && chars[i] != "6" && chars[i] != "7" && chars[i] != "8" && chars[i] != "9")
                    {
                        operator1 = Convert.ToString(chars[i]);
                        break;
                    }
                }

                int num1 = Convert.ToInt32(string.Join("", firstNum));
                int num2 = Convert.ToInt32(string.Join("", secondNum));


                if (operator1 == "+")
                {
                    textBox1.Text = Convert.ToString(num1 + num2);
                }
                else if (operator1 == "-")
                {
                    textBox1.Text = Convert.ToString(num1 - num2);
                }
                else if (operator1 == "*")
                {
                    textBox1.Text = Convert.ToString(num1 * num2);
                }
                else if (operator1 == "/")
                {
                    textBox1.Text = Convert.ToString(num1 / num2);
                }
                else
                {
                    textBox1.Text = "None";
                }

            }
        }


    
}
}
