using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isProccesContinue;
        private bool btnResult;
        private double result;
        private byte counter;
        private char[] operation;
        private double[] numbers;

        private void Form1_Load(object sender, EventArgs e)
        {
            isProccesContinue = btnResult = false;
            operation = new char[0];
            numbers = new double[0];
            counter = 0;
            result = 0;
        }

        private void number_Click(object sender, EventArgs e)
        {
            if (btnResult)
            {
                btnClearProcces_Click(btnClearProcces, e);
                btnResult = false;
            }
            if (!isProccesContinue)
                proccesLabel.Text = string.Empty;
            proccesLabel.Text += ((Button)sender).Text;
            isProccesContinue = true;
            btnShowResult.Focus();
        }

        private void operation_Click(object sender, EventArgs e)
        {
            if (!btnResult)
            {
                counter++;
                Array.Resize(ref numbers, counter);
                Array.Resize(ref operation, counter);
                numbers[counter - 1] = Convert.ToDouble(proccesLabel.Text);
                operation[counter - 1] = Convert.ToChar(((Button)sender).Text);
                isProccesContinue = false;
                bufferLabel.Text += proccesLabel.Text + " " + ((Button)sender).Text + " ";
                if (counter == 1)
                    result = numbers[counter - 1];
                else
                {
                    switch (operation[counter - 2])
                    {
                        case '%':
                            result = result % numbers[counter - 1];
                            break;
                        case '+':
                            result += numbers[counter - 1];
                            break;
                        case '-':
                            result -= numbers[counter - 1];
                            break;
                        case 'x':
                            result *= numbers[counter - 1];
                            break;
                        case '÷':
                            result /= numbers[counter - 1];
                            break;
                        default:
                            break;
                    }
                }

                proccesLabel.Text = result.ToString();
            }
            else
            {
                counter = 0;
                result = Convert.ToDouble(proccesLabel.Text);
                bufferLabel.Text = string.Empty;
                counter++;
                Array.Clear(numbers, 0, numbers.Length);
                Array.Clear(operation, 0, operation.Length);
                Array.Resize(ref numbers, counter);
                Array.Resize(ref operation, counter);
                numbers[counter - 1] = Convert.ToDouble(proccesLabel.Text);
                operation[counter - 1] = Convert.ToChar(((Button)sender).Text);
                isProccesContinue = btnResult = false;
                bufferLabel.Text += proccesLabel.Text + " " + ((Button)sender).Text + " ";
                proccesLabel.Text = result.ToString();
            }
            btnShowResult.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    number_Click(btnNumberZero, e);
                    break;
                case Keys.NumPad1:
                    number_Click(btnNumberOne, e);
                    break;
                case Keys.NumPad2:
                    number_Click(btnNumberTwo, e);
                    break;
                case Keys.NumPad3:
                    number_Click(btnNumberThree, e);
                    break;
                case Keys.NumPad4:
                    number_Click(btnNumberFour, e);
                    break;
                case Keys.NumPad5:
                    number_Click(btnNumberFive, e);
                    break;
                case Keys.NumPad6:
                    number_Click(btnNumberSix, e);
                    break;
                case Keys.NumPad7:
                    number_Click(btnNumberSeven, e);
                    break;
                case Keys.NumPad8:
                    number_Click(btnNumberEight, e);
                    break;
                case Keys.NumPad9:
                    number_Click(btnNumberNine, e);
                    break;
                case Keys.D0:
                    number_Click(btnNumberZero, e);
                    break;
                case Keys.D1:
                    number_Click(btnNumberOne, e);
                    break;
                case Keys.D2:
                    number_Click(btnNumberTwo, e);
                    break;
                case Keys.D3:
                        number_Click(btnNumberThree, e);
                    break;
                case Keys.D4:
                    number_Click(btnNumberFour, e);
                    break;
                case Keys.D5:
                    if (e.Modifiers != Keys.Shift)
                        number_Click(btnNumberFive, e);
                    else
                        operation_Click(btnMod, e);
                    break;
                case Keys.D6:
                    number_Click(btnNumberSix, e);
                    break;
                case Keys.D7:
                    number_Click(btnNumberSeven, e);
                    break;
                case Keys.D8:
                    number_Click(btnNumberEight, e);
                    break;
                case Keys.D9:
                    number_Click(btnNumberNine, e);
                    break;
                case Keys.Multiply:
                    operation_Click(btnMultiplication, e);
                    break;
                case Keys.Add:
                    operation_Click(btnAddition, e);
                    break;
                case Keys.Separator:
                    operation_Click(btnMod, e);
                    break;
                case Keys.Subtract:
                    operation_Click(btnSubstraction, e);
                    break;
                case Keys.Decimal:
                    proccesLabel.Text += ',';
                    break;
                case Keys.Divide:
                    operation_Click(btnDivision, e);
                    break;
                case Keys.Oemcomma:
                    proccesLabel.Text += ',';
                    break;
                case Keys.Back:
                    btnDelete_Click(btnDelete, e);
                    break;
                default:
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (proccesLabel.Text.Length > 0 && isProccesContinue)
            {
                proccesLabel.Text = proccesLabel.Text.Remove(proccesLabel.Text.Length
                     - 1);
                if (proccesLabel.Text.Length == 0)
                {
                    proccesLabel.Text = "0";
                    isProccesContinue = false;
                }
            }
            btnShowResult.Focus();
        }

        private void btnClearProcces_Click(object sender, EventArgs e)
        {
            result = 0;
            Array.Clear(numbers, 0, numbers.Length);
            Array.Clear(operation, 0, operation.Length);
            isProccesContinue = false;
            bufferLabel.Text = string.Empty;
            proccesLabel.Text = "0";
        }

        private void btnClearNow_Click(object sender, EventArgs e)
        {
            isProccesContinue = false;
            proccesLabel.Text = "0";
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                btnResult = true;
                switch (operation[counter - 1])
                {
                    case '%':
                        result = result % Convert.ToDouble(proccesLabel.Text);
                        bufferLabel.Text += proccesLabel.Text + " = ";
                        break;
                    case '+':
                        result += Convert.ToDouble(proccesLabel.Text);
                        bufferLabel.Text += proccesLabel.Text + " = ";
                        break;
                    case '-':
                        result -= Convert.ToDouble(proccesLabel.Text);
                        bufferLabel.Text += proccesLabel.Text + " = ";
                        break;
                    case 'x':
                        result *= Convert.ToDouble(proccesLabel.Text);
                        bufferLabel.Text += proccesLabel.Text + " = ";
                        break;
                    case '÷':
                        result /= Convert.ToDouble(proccesLabel.Text);
                        bufferLabel.Text += proccesLabel.Text + " = ";
                        break;
                    default:
                        break;
                }
                proccesLabel.Text = result.ToString();
            }
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            bufferLabel.Text = "1 ÷ " + Convert.ToDouble(proccesLabel.Text).ToString() + " = ";
            if (Convert.ToDouble(proccesLabel.Text) != 0)
                proccesLabel.Text = (1 / Convert.ToDouble(proccesLabel.Text)).ToString();
            else
                proccesLabel.Text = "Sıfıra Bölünmez";
            btnResult = true;
            isProccesContinue = false;
        }

        private void btnPowX_Click(object sender, EventArgs e)
        {
            bufferLabel.Text = Convert.ToDouble(proccesLabel.Text).ToString() + "²" + " = ";
            proccesLabel.Text = Math.Pow(Convert.ToDouble(proccesLabel.Text), 2).ToString();
            btnResult = true;
            isProccesContinue = false;
        }

        private void btnSqrtX_Click(object sender, EventArgs e)
        {
            bufferLabel.Text = "√" + Convert.ToDouble(proccesLabel.Text).ToString() + " = ";
            if (Convert.ToDouble(proccesLabel.Text) >= 0)
                proccesLabel.Text = Math.Sqrt(Convert.ToDouble(proccesLabel.Text)).ToString();
            else
                proccesLabel.Text = "Geçersiz Giriş!";
            btnResult = true;
            isProccesContinue = false;
        }

        private void btnFlipSign_Click(object sender, EventArgs e)
        {
            result *= -1;
            proccesLabel.Text = result.ToString();
        }
    }
}