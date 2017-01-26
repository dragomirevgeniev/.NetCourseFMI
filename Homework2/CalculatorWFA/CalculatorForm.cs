using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem1.c_Calculator
{
    public partial class CalculatorForm : Form
    {
        private enum Operation
        {
            NO_OPERATION,
            PLUS,
            MINUS,
            MULTIPLY,
            DEVIDE,
            EXP,
            SIN,
            COS,
            SQRT,
            LOG,
            RATIONAL1X
        }

        private Operation operation; // holds the current operation
        private double inputData;    // holds the current input value
        private double result;       // holds the final result
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void AddDigit(string digit)
        {
            if (inputField.Text != "0")
            {
                inputField.Text += digit;
            }
            else
            {
                inputField.Text = digit;
            }
        }
        private void ExecuteOperation(Operation op)
        {
            inputData = Convert.ToDouble(inputField.Text);
            inputField.Text = "0";
            operation = op;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDigit("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddDigit("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddDigit("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            AddDigit("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddDigit("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddDigit("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            AddDigit("7");
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            AddDigit("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            AddDigit("9");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            AddDigit("0");
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            AddDigit("00");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddDigit(",");
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(inputField.Text);
            switch (operation)
            {
                case Operation.NO_OPERATION:
                    result = value;
                    break;
                case Operation.PLUS:
                    result = inputData + value;
                    break;
                case Operation.MINUS:
                    result = inputData - value;
                    break;
                case Operation.MULTIPLY:
                    result = inputData * value;
                    break;
                case Operation.DEVIDE:
                    if (Math.Abs(value) > Math.Abs(double.MinValue))
                    {
                        result = inputData / value;
                    }
                    else
                    {
                        result = double.MaxValue;
                        inputField.Text = "Invalid input!";
                    }
                    break;
                case Operation.SIN:
                    result = Math.Sin(inputData);
                    break;
                case Operation.COS:
                    result = Math.Cos(inputData);
                    break;
                case Operation.EXP:
                    result = Math.Exp(inputData);
                    break;
                case Operation.SQRT:
                    result = Math.Sqrt(inputData);
                    break;
                case Operation.LOG:
                    result = Math.Log10(inputData);
                    break;
                case Operation.RATIONAL1X:
                    result = 1 / inputData;
                    break;
                default:
                    break;
            }

            operation = Operation.NO_OPERATION;
            inputField.Text = "" + result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operation.PLUS);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (inputField.Text != "0" && inputField.Text != "-")
            {
                ExecuteOperation(Operation.MINUS);
            }
            else if (inputField.Text == "-")
            {
            }
            else
            {
                AddDigit("-");
            }
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operation.DEVIDE);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operation.MULTIPLY);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operation.SIN);
            btnEquals_Click(null, EventArgs.Empty);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operation.COS);
            btnEquals_Click(null, EventArgs.Empty);
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operation.EXP);
            btnEquals_Click(null, EventArgs.Empty);
        }
  
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operation.SQRT);
            btnEquals_Click(null, EventArgs.Empty);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operation.LOG);
            btnEquals_Click(null, EventArgs.Empty);
        }

        private void btnRational1X_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operation.RATIONAL1X);
            btnEquals_Click(null, EventArgs.Empty);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text.Remove(0, inputField.Text.Length);
            AddDigit("0");
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text.Remove(0, inputField.Text.Length);
            operation = Operation.NO_OPERATION;
            AddDigit("0");
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
