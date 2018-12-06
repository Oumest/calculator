using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcV2
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;
        double secondNumber;
        double result;
        List<double> lst_memory = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
            this.ActiveControl = bEqu;
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
            this.ActiveControl = bEqu;
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
            this.ActiveControl = bEqu;
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
            this.ActiveControl = bEqu;
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
            this.ActiveControl = bEqu;
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
            this.ActiveControl = bEqu;
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
            this.ActiveControl = bEqu;
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
            this.ActiveControl = bEqu;
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
            this.ActiveControl = bEqu;
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
            this.ActiveControl = bEqu;
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {

            }
            else
            {
                textBox1.Text += ".";
            }
            this.ActiveControl = bEqu;
        }

        private void bRet_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            this.ActiveControl = bEqu;
        }

        private void bClearAll_Click(object sender, EventArgs e)
        {
            //rensar alla lagrade värde
            lst_memory.Clear();
            comboBox1.Items.Clear();
            textBox1.Text = "0"; 
            if ((firstNumber.ToString().Length >= 1) || (secondNumber.ToString().Length >= 1))
            {
                firstNumber = 0;
                secondNumber = 0;
                result = 0;
            }
            this.ActiveControl = bEqu;
        }

        private void bMul_Click(object sender, EventArgs e)
        {
                firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "0";
                operation = "*";
            this.ActiveControl = bEqu;
        }


        private void bDiv_Click(object sender, EventArgs e)
        {
                firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "0";
                operation = "/";
            this.ActiveControl = bEqu;
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
                firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "0";
                operation = "-";
            this.ActiveControl = bEqu;
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
                firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "0";
                operation = "+";
            this.ActiveControl = bEqu;
        }

        private void bEqu_Click(object sender, EventArgs e)
        {
                secondNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                if (operation == "+")
                {
                    result = firstNumber + secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                }
                if (operation == "-")
                {
                    result = firstNumber - secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                }
                if (operation == "*")
                {
                    result = firstNumber * secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                }
                if (operation == "/")
                {
                    if (secondNumber == 0)
                    {
                        textBox1.Text = "Cannot divide by zero";
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                        textBox1.Text = Convert.ToString(result);
                        firstNumber = result;
                    }
                }
            this.ActiveControl = bEqu;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = "0";
            }
            this.ActiveControl = bEqu;
        }

        private void bPosNeg_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                double num = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                if (num > 0 || num < 0)
                {
                    num = num * -1;
                    textBox1.Text = Convert.ToString(num);
                }
                else { }
            }
            this.ActiveControl = bEqu;
        }

        private void bRoot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1 && textBox1.Text != "0")
            {
                double num = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                if (num > 0)
                {
                    num = Math.Sqrt(num);
                    textBox1.Text = Convert.ToString(num);
                }
            }
            this.ActiveControl = bEqu;
        }

        private void bPow_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1 && textBox1.Text != "0")
            {
                double num = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                num = Math.Pow(num, 2);
                textBox1.Text = Convert.ToString(num);
            }
            this.ActiveControl = bEqu;
        }

        private void bFrac_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1 && textBox1.Text != "0")
            {
                double num = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                num = 1 / num;
                textBox1.Text = Convert.ToString(num);
            }
            this.ActiveControl = bEqu;
        }

        private void bRest_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            num = num * (num / 100);
            textBox1.Text = Convert.ToString(num);
            this.ActiveControl = bEqu;
        }

        private void bMemGet_Click(object sender, EventArgs e)
        {
            double num = lst_memory.LastOrDefault(); // visar sista värde som har lagts till i memory. Om inget värde finns då visas 0 på textbox
            textBox1.Text = Convert.ToString(num);
            this.ActiveControl = bEqu;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                textBox1.Text = string.Empty;
            }
            else
            {
                textBox1.Text = comboBox1.SelectedItem.ToString();
            }
            this.ActiveControl = bEqu;
        }

        private void bMemAdd_Click(object sender, EventArgs e)
        {

            double num = double.Parse(textBox1.Text, CultureInfo.InvariantCulture); 
            if (lst_memory.Contains(num))
            {
                //om siffran i textbox redan finns i combobox då händer inget
            }
            else
            {
                lst_memory.Add(num);
                comboBox1.Items.Add(num);
            }
            this.ActiveControl = bEqu;
        }

        private void bMemSub_Click(object sender, EventArgs e)
        {
            double reqNum = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
               for (int i = 0; i < lst_memory.Count(); i++) // loopar genom alla värde i memory list
                {
                    if (reqNum == lst_memory[i]) // om siffran finns i memory list då tas det bort från  memory och combobox
                    {
                        lst_memory.Remove(reqNum);
                        comboBox1.Items.Remove(reqNum);
                        i--;
                    }
                }
            this.ActiveControl = bEqu;
        }

        private void bMemClean_Click(object sender, EventArgs e)
        {
            lst_memory.Clear();
            comboBox1.Items.Clear();
            this.ActiveControl = bEqu;
        }


        private void n1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                if (textBox1.Text == "1" && textBox1.Text != null)
                {
                    textBox1.Text = "1";
                    e.Handled = true;
                }
                else
                {
                    textBox1.Text += "1";
                    e.Handled = true;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text += "0";
                    }
                    break;
                case Keys.NumPad1:
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "1";
                    }
                    else
                    {
                        textBox1.Text += "1";
                    }
                    break;
                // .. etc
                case Keys.NumPad2:
                    
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "2";
                    }
                    else
                    {
                        textBox1.Text += "2";
                    }
                    break;
                case Keys.NumPad3:
                    
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "3";
                    }
                    else
                    {
                        textBox1.Text += "3";
                    }
                    break;
                case Keys.NumPad4:
                    
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "4";
                    }
                    else
                    {
                        textBox1.Text += "4";
                    }
                    break;
                case Keys.NumPad5:
                    
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "5";
                    }
                    else
                    {
                        textBox1.Text += "5";
                    }
                    break;
                case Keys.NumPad6:
                    
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "6";
                    }
                    else
                    {
                        textBox1.Text += "6";
                    }
                    break;
                case Keys.NumPad7:
                    
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "7";
                    }
                    else
                    {
                        textBox1.Text += "7";
                    }
                    break;
                case Keys.NumPad8:
                    
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "8";
                    }
                    else
                    {
                        textBox1.Text += "8";
                    }
                    break;
                case Keys.NumPad9:
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "9";
                    }
                    else
                    {
                        textBox1.Text += "9";
                    }
                    break;
                case Keys.Add:
                    firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                    textBox1.Text = "0";
                    operation = "+";
                    break;
                case Keys.Subtract:
                    firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                    textBox1.Text = "0";
                    operation = "-";
                    break;
                case Keys.Multiply:
                    firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                    textBox1.Text = "0";
                    operation = "*";
                    break;
                case Keys.Divide:
                    firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                    textBox1.Text = "0";
                    operation = "/";
                    break;
                case Keys.Oemcomma:
                    if (textBox1.Text.Contains("."))
                    {

                    }
                    else
                    {
                        textBox1.Text += ".";
                    }
                    break;
                case Keys.Back:
                    if (textBox1.Text != "0" && textBox1.Text != null)
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    }
                    else if (textBox1.Text == null)
                    {
                    }
                    break;
                case Keys.Clear:
                    if (textBox1.Text != "0")
                    {
                        textBox1.Text = "0";
                    }
                    break;
                case Keys.Return:
                    secondNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                    if (operation == "+")
                    {
                        result = firstNumber + secondNumber;
                        textBox1.Text = Convert.ToString(result);
                        firstNumber = result;
                        break;
                    }
                    if (operation == "-")
                    {
                        result = firstNumber - secondNumber;
                        textBox1.Text = Convert.ToString(result);
                        firstNumber = result;
                        break;
                    }
                    if (operation == "*")
                    {
                        result = firstNumber * secondNumber;
                        textBox1.Text = Convert.ToString(result);
                        firstNumber = result;
                        break;
                    }
                    if (operation == "/")
                    {
                        if (secondNumber == 0)
                        {
                            textBox1.Text = "Cannot divide by zero";
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                            textBox1.Text = Convert.ToString(result);
                            firstNumber = result;
                        }
                        break;
                    }
                    break;
                default:
                                    
                    return;
            }
            e.Handled = true;
        }
    }
}