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

        public StdCalculator()
        {
            InitializeComponent();
        }

        private void Form1(object sender, EventArgs e)
        {

        }

        private void TextResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
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
            txtResult.Text += "6";
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

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            v = -v;
            txtResult.Text = v.ToString();
        }

        private void AdditionBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text += "+";
        }

        private void SubtractionBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text += "−";
        }

        private void MultiplicationBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text += "×";
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text += "/";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
        }

        private void MemoryClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void MemoryPlusBtn_Click(object sender, EventArgs e)
        {

        }

        private void MemoryMinusBtn_Click(object sender, EventArgs e)
        {

        }

        private void MemoryRecallBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
