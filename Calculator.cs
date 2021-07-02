﻿using System;
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
        OperatorClass solve = new OperatorClass();
        MemoryClass mem = new MemoryClass();

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
            AddDetails();
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            SubtractDetails();
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            MultiplyDetails();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            DivideDetails();
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
            if (txtResult.Text == "0" || solve.IsOperationPressed == true || mem.IsMemory == true)
            {
                txtResult.Text = number;
                solve.IsOperationPressed = false;
                mem.IsMemory = false;
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

        private void AddDetails()
        {
            solve.FirstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " + ";
            solve.Operation = "+";
            solve.IsOperationPressed = true;
            solve.Num2 = txtResult.Text;
            solve.Add();
        }

        private void SubtractDetails()
        {
            solve.FirstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " − ";
            solve.Operation = "−";
            solve.IsOperationPressed = true;
            solve.Num2 = txtResult.Text;
            solve.Subtract();
        }

        private void MultiplyDetails()
        {
            solve.FirstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " × ";
            solve.Operation = "×";
            solve.IsOperationPressed = true;
            solve.Num2 = txtResult.Text;
            solve.Multiply();
        }

        private void DivideDetails()
        {
            solve.FirstValue = txtResult.Text;
            displayOutputLbl.Text = txtResult.Text + " ÷ ";
            solve.Operation = "÷";
            solve.IsOperationPressed = true;
            solve.Num2 = txtResult.Text;
            solve.Divide();
        }

        private void Equal()
        {
            solve.Num2 = txtResult.Text;
            if (solve.Operation.Equals("+"))
            {
                solve.Add();
            }
            else if (solve.Operation.Equals("−"))
            {
                solve.Subtract();
            }
            else if (solve.Operation.Equals("×"))
            {
                mem.Multiply();
            }
            else if (solve.Operation.Equals("÷"))
            {
                mem.Divide();
            }

            txtResult.Text = solve.Num2;

            DisplayResult();
        }

        private void DisplayResult()
        {
            if (solve.FirstValue == "0")
            {
                displayOutputLbl.Text = Convert.ToString(Double.Parse(txtResult.Text) + " = ");
            }
            else
            {
                displayOutputLbl.Text = Convert.ToString(solve.FirstValue + " " + solve.Operation + " " + solve.SecondValue + " = ");
            }
        }

        private void Clear()
        {
            txtResult.Text = "0";
            displayOutputLbl.Text = "";
            solve.FirstValue = "0";
            solve.Operation = "";
            solve.IsOperationPressed = false;
        }

        private void Delete()
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text == "")
                txtResult.Text = "0";
        }

        private void MemoryClear()
        {
            mem.Memory = 0;
            MemoryReadBtn.Enabled = false;
            MemoryClearBtn.Enabled = false;
        }

        private void MemoryRead()
        {
            txtResult.Text = mem.Memory.ToString();
            mem.IsMemory = true;
        }

        private void MemoryPlus()
        {
            mem.Memory += Double.Parse(txtResult.Text);
            MemoryReadBtn.Enabled = true;
            MemoryClearBtn.Enabled = true;
        }

        private void MemoryMinus()
        {
            mem.Memory -= Double.Parse(txtResult.Text);
            MemoryReadBtn.Enabled = true;
            MemoryClearBtn.Enabled = true;
        }

        private void MemorySave()
        {
            mem.Memory = Double.Parse(txtResult.Text);
            MemoryReadBtn.Enabled = true;
            MemoryClearBtn.Enabled = true;
            mem.IsMemory = true;
        }
    }
}