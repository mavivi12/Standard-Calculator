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

        private void TextOutput(object sender, EventArgs e)
        {

        }

        private void Number0_Click(object sender, EventArgs e)
        {
            textOutput.Text += "0";
            //if (textOutput.Text == "")
            //    textOutput.Text = "0";
            //else
            //    textOutput.Text += "0";
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            textOutput.Text += "1";
            //if (textOutput.Text == "0")
            //    textOutput.Text = "1";
            //else
            //    textOutput.Text += "1";
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            textOutput.Text += "2";
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            textOutput.Text += "3";
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            textOutput.Text += "4";
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            textOutput.Text += "6";
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            textOutput.Text += "6";
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            textOutput.Text += "7";
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            textOutput.Text += "8";
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            textOutput.Text += "9";
        }

        private void PointBtn_Click(object sender, EventArgs e)
        {
            textOutput.Text += ".";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            textOutput.Text += "=";
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdditionBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void SubtractionBtn_Click(object sender, EventArgs e)
        {

        }

        private void MultiplicationBtn_Click(object sender, EventArgs e)
        {

        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textOutput.Text = "";
        }

        private void BackspaceBtn_Click(object sender, EventArgs e)
        {
            
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
