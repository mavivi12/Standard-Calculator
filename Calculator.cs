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
        Double resultVal = 0;
        String operation = "";
        bool isOperationPressed = false;
        String firstnumber, secondnumber;
        private double memory = 0;

        public StdCalculator()
        {
            InitializeComponent();
            
            MemoryRecallBtn.Enabled = false;
            MemoryClearBtn.Enabled = false;
        }

        private void NumberBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if ((txtResult.Text == "0") || isOperationPressed)
              txtResult.Text = "";
            isOperationPressed = false;

            if (btn.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text += btn.Text;
            }
            else
            {
                txtResult.Text += btn.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button oper = (Button)sender;

                if (resultVal != 0)
                {
                    EqualBtn.PerformClick();
                    isOperationPressed = true;
                    operation = oper.Text;
                    displayOutputLbl.Text = resultVal + " " + operation;
                }
                else
                {
                    operation = oper.Text;
                    resultVal = Double.Parse(txtResult.Text);
                    isOperationPressed = true;
                    displayOutputLbl.Text = resultVal + " " + operation;
                }

            firstnumber = displayOutputLbl.Text;
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            secondnumber = txtResult.Text;

            switch (operation)
            {
                case "+":
                    txtResult.Text = (resultVal + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "−":
                    txtResult.Text = (resultVal - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "×":
                    txtResult.Text = (resultVal * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "÷":
                    txtResult.Text = (resultVal / Double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultVal = Double.Parse(txtResult.Text);

            if (txtResult.Text == "")
            {
                displayOutputLbl.Text = "";
                txtResult.Text = "";
            }
            else
            {
                displayOutputLbl.Text = (firstnumber + " " + secondnumber + " =");
            }
            operation = "";
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                if (txtResult.Text == "-")
                {
                    txtResult.Text = "";
                }
            }
            else
            {
                double v = Double.Parse(txtResult.Text);
                v = -v;
                txtResult.Text = v.ToString();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            displayOutputLbl.Text = "";
            resultVal = 0;
            operation = "";
            isOperationPressed = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            }
        }

        private void MemoryClearBtn_Click(object sender, EventArgs e)
        {
            memory = 0;
            MemoryRecallBtn.Enabled = false;
            MemoryClearBtn.Enabled = false;
        }

        private void MemoryPlusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                memory += Double.Parse(txtResult.Text);
            }
            catch
            {
                txtResult.Text = "";
            }
        }

        private void MemoryMinusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                memory -= Double.Parse(txtResult.Text);
            }
            catch
            {
                txtResult.Text = "";
            }
        }

        private void MemoryRecallBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text = memory.ToString();
        }

        private void MemorySaveBtn_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                memory = 0;
                MemoryRecallBtn.Enabled = true;
                MemoryClearBtn.Enabled = true;
            }
            else
            {
                memory = Double.Parse(txtResult.Text);
                MemoryRecallBtn.Enabled = true;
                MemoryClearBtn.Enabled = true;
            }
        }
    }
}
