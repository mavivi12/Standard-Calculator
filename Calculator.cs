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
        String firstValue = "";
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
            NumberInput("0");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            NumberInput("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            NumberInput("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            NumberInput("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            NumberInput("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            NumberInput("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            NumberInput("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            NumberInput("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            NumberInput("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            NumberInput("9");
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            Decimal();
        }

        private void NegativeOrPositive_Click(object sender, EventArgs e)
        {
            Negative();
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            Equal();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void MemoryClearBtn_Click(object sender, EventArgs e)
        {
            MemoryClear();
        }

        private void MemoryReadBtn_Click(object sender, EventArgs e)
        {
            MemoryRead();
        }

        private void MemoryPlusBtn_Click(object sender, EventArgs e)
        {
            MemoryPlus();
        }

        private void MemoryMinusBtn_Click(object sender, EventArgs e)
        {
            MemoryMinus();
        }

        private void MemorySaveBtn_Click(object sender, EventArgs e)
        {
            MemorySave();
        }

        private void NumberInput(string number)
        {
            if (txtResult.Text == "0" || isOperationPressed == true || isMemory == true)
            {
                txtResult.Text = number;
                isOperationPressed = false;
                isMemory = false;
            }
            else
                txtResult.Text += number;
        }

        private void Decimal()
        {
            if (txtResult.Text.Contains("."))
                txtResult.Text = txtResult.Text;
            else
                txtResult.Text += ".";
        }

        private void Negative()
        {
            double v = Double.Parse(txtResult.Text);
            v = -v;
            txtResult.Text = v.ToString();
        }

        private void Add()
        {
            firstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " + ";
            operation = "+";
            isOperationPressed = true;
        }

        private void Subtract()
        {
            firstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " − ";
            operation = "−";
            isOperationPressed = true;
        }

        private void Multiply()
        {
            firstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " × ";
            operation = "×";
            isOperationPressed = true;
        }

        private void Divide()
        {
            firstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " ÷ ";
            operation = "÷";
            isOperationPressed = true;
        }

        private void Equal()
        {
            Double secondValue = Double.Parse(txtResult.Text);
            switch (operation)
            {
                case "+":
                    txtResult.Text = (Double.Parse(firstValue) + secondValue).ToString();
                    break;
                case "−":
                    txtResult.Text = (Double.Parse(firstValue) - secondValue).ToString();
                    break;
                case "×":
                    txtResult.Text = (Double.Parse(firstValue) * secondValue).ToString();
                    break;
                case "÷":
                    txtResult.Text = (Double.Parse(firstValue) / secondValue).ToString();
                    break;
                default:
                    break;
            }

            if (firstValue == "0")
            {
                displayOutputLbl.Text = Convert.ToString(Double.Parse(txtResult.Text) + " = ");
            }
            else
            {
                displayOutputLbl.Text = Convert.ToString(firstValue + " " + operation + " " + secondValue + " = ");
            }
        }

        private void Clear()
        {
            txtResult.Text = "0";
            displayOutputLbl.Text = "";
            firstValue = "0";
            operation = "";
            isOperationPressed = false;
        }

        private void Delete()
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text == "")
                txtResult.Text = "0";
        }

        private void MemoryClear()
        {
            memory = 0;
            MemoryReadBtn.Enabled = false;
            MemoryClearBtn.Enabled = false;
        }

        private void MemoryRead()
        {
            txtResult.Text = memory.ToString();
            isMemory = true;
        }

        private void MemoryPlus()
        {
            memory += Double.Parse(txtResult.Text);
            MemoryReadBtn.Enabled = true;
            MemoryClearBtn.Enabled = true;
        }

        private void MemoryMinus()
        {
            memory -= Double.Parse(txtResult.Text);
            MemoryReadBtn.Enabled = true;
            MemoryClearBtn.Enabled = true;
        }

        private void MemorySave()
        {
            memory = Double.Parse(txtResult.Text);
            MemoryReadBtn.Enabled = true;
            MemoryClearBtn.Enabled = true;
            isMemory = true;
        }
    }
}