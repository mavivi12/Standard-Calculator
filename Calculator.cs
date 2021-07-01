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
        private double memory = 0;

        public StdCalculator()
        {
            InitializeComponent();

            MemoryReadBtn.Enabled = false;
            MemoryClearBtn.Enabled = false;
        }

        private void StdCalculator_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";

            if (txtResult.Text == "0")
            {
                txtResult.Clear();
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void PointBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text += "=";
        }

        private void NegativeOrPositive_Click(object sender, EventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            v = -v;
            txtResult.Text = v.ToString();
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            displayOutputLbl.Text = txtResult.Text + " +";

        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            displayOutputLbl.Text = txtResult.Text + " −";
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            displayOutputLbl.Text = txtResult.Text + " ×";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            displayOutputLbl.Text = txtResult.Text + " ÷";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
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
            MemoryReadBtn.Enabled = false;
            MemoryClearBtn.Enabled = false;
        }

        private void MemoryPlusBtn_Click(object sender, EventArgs e)
        {
            memory += double.Parse(txtResult.Text);
        }

        private void MemoryMinusBtn_Click(object sender, EventArgs e)
        {
            memory -= double.Parse(txtResult.Text);
        }

        private void MemoryRecallBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text = memory.ToString();
        }

        private void MemorySaveBtn_Click(object sender, EventArgs e)
        {
            memory = double.Parse(txtResult.Text);
            MemoryReadBtn.Enabled = true;
            MemoryClearBtn.Enabled = true;
        }
    }
}