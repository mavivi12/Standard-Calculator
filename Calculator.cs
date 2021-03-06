using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standard_Calculator
{
    public partial class StdCalculator : System.Windows.Forms.Form
    {
        Double memory = 0;
        String firstValue;
        String operation = "";
        Boolean isOperationPressed = false;
        Boolean isMemory = false;

        public StdCalculator()
        {
            InitializeComponent();
        }

        private void StdCalculator_Load(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            MemoryReadBtn.Enabled = false;
            MemoryClearBtn.Enabled = false;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "0";
                isOperationPressed = false;
                isMemory = false;
            }
            else if (displayOutputLbl.Text.Contains("="))
            {
                txtResult.Text = "0";
                txtResult.Text = "0";
                displayOutputLbl.Text = "";
                isOperationPressed = false;
            }
            else
                txtResult.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "1";
                isOperationPressed = false;
                isMemory = false;
            }
            else if (displayOutputLbl.Text.Contains("="))
            {
                txtResult.Text = "0";
                txtResult.Text = "1";
                displayOutputLbl.Text = "";
                isOperationPressed = false;
            }
            else
                txtResult.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "2";
                isOperationPressed = false;
                isMemory = false;
            }
            else if (displayOutputLbl.Text.Contains("="))
            {
                txtResult.Text = "0";
                txtResult.Text = "2";
                displayOutputLbl.Text = "";
                isOperationPressed = false;
            }
            else
                txtResult.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "3";
                isOperationPressed = false;
                isMemory = false;
            }
            else if (displayOutputLbl.Text.Contains("="))
            {
                txtResult.Text = "0";
                txtResult.Text = "3";
                displayOutputLbl.Text = "";
                isOperationPressed = false;
            }
            else
                txtResult.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "4";
                isOperationPressed = false;
                isMemory = false;
            }
            else if (displayOutputLbl.Text.Contains("="))
            {
                txtResult.Text = "0";
                txtResult.Text = "4";
                displayOutputLbl.Text = "";
                isOperationPressed = false;
            }
            else
                txtResult.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "5";
                isOperationPressed = false;
                isMemory = false;
            }
            else if (displayOutputLbl.Text.Contains("="))
            {
                txtResult.Text = "0";
                txtResult.Text = "5";
                displayOutputLbl.Text = "";
                isOperationPressed = false;
            }
            else
                txtResult.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "6";
                isOperationPressed = false;
                isMemory = false;
            }
            else if (displayOutputLbl.Text.Contains("="))
            {
                txtResult.Text = "0";
                txtResult.Text = "6";
                displayOutputLbl.Text = "";
                isOperationPressed = false;
            }
            else
                txtResult.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "7";
                isOperationPressed = false;
                isMemory = false;
            }
            else if (displayOutputLbl.Text.Contains("="))
            {
                txtResult.Text = "0";
                txtResult.Text = "7";
                displayOutputLbl.Text = "";
                isOperationPressed = false;
            }
            else
                txtResult.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "8";
                isOperationPressed = false;
                isMemory = false;
            }
            else if (displayOutputLbl.Text.Contains("="))
            {
                txtResult.Text = "0";
                txtResult.Text = "8";
                displayOutputLbl.Text = "";
                isOperationPressed = false;
            }
            else
                txtResult.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "9";
                isOperationPressed = false;
                isMemory = false;
            }
            else if (displayOutputLbl.Text.Contains("="))
            {
                txtResult.Text = "0";
                txtResult.Text = "9";
                displayOutputLbl.Text = "";
                isOperationPressed = false;
            }
            else
                txtResult.Text += "9";
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            if (txtResult.TextLength > 0 && txtResult.Text.Contains("."))
            {
                txtResult.Text = "0";
                txtResult.Text += ".";
                isOperationPressed = false;
            }
            else if (isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = "0";
                txtResult.Text += ".";
            }
            else if (txtResult.Text.Contains("."))
            {
                txtResult.Text = txtResult.Text;
            }
            else
                txtResult.Text += ".";
        }

        private void NegativeOrPositive_Click(object sender, EventArgs e)
        {
            Double v = Double.Parse(txtResult.Text);
            v = -v;
            txtResult.Text = v.ToString();
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            firstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " + ";
            operation = "+";
            isOperationPressed = true;
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            firstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " − ";
            operation = "−";
            isOperationPressed = true;
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            firstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " × ";
            operation = "×";
            isOperationPressed = true;
        }

        private void Division_Click(object sender, EventArgs e)
        {
            firstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " ÷ ";
            operation = "÷";
            isOperationPressed = true;
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            String secondValue = Double.Parse(txtResult.Text).ToString();

            if (operation.Equals("+"))
            {
                txtResult.Text = (Double.Parse(firstValue) + Double.Parse(secondValue)).ToString();
            }
            else if (operation.Equals("−"))
            {
                txtResult.Text = (Double.Parse(firstValue) - Double.Parse(secondValue)).ToString();
            }
            else if (operation.Equals("×"))
            {
                txtResult.Text = (Double.Parse(firstValue) * Double.Parse(secondValue)).ToString();
            }
            else if (operation.Equals("÷"))
            {
                txtResult.Text = (Double.Parse(firstValue) / Double.Parse(secondValue)).ToString();
            }

            if (firstValue == "0")
            {
                displayOutputLbl.Text = secondValue + " = ";
            }
            else
            {
                displayOutputLbl.Text = Convert.ToString(firstValue + " " + operation + " " + secondValue + " = ");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            displayOutputLbl.Text = "";
            firstValue = "0";
            operation = "";
            isOperationPressed = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text == "")
                txtResult.Text = "0";
        }

        private void MemoryClearBtn_Click(object sender, EventArgs e)
        {
            memory = 0;
            MemoryReadBtn.Enabled = false;
            MemoryClearBtn.Enabled = false;
        }

        private void MemoryReadBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text = memory.ToString();
            isMemory = true;
        }

        private void MemoryPlusBtn_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(txtResult.Text);
            MemoryReadBtn.Enabled = true;
            MemoryClearBtn.Enabled = true;
        }

        private void MemoryMinusBtn_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(txtResult.Text);
            MemoryReadBtn.Enabled = true;
            MemoryClearBtn.Enabled = true;
        }

        private void MemorySaveBtn_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(txtResult.Text);
            MemoryReadBtn.Enabled = true;
            MemoryClearBtn.Enabled = true;
            isMemory = true;
        }
    }
}