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
            int number0 = 0;
            textOutput.Text = number0.ToString();
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            int number1 = 1;
            textOutput.Text = number1.ToString();
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            int number2 = 2;
            textOutput.Text = number2.ToString();
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            int number3 = 3;
            textOutput.Text = number3.ToString();

        }

        private void Number4_Click(object sender, EventArgs e)
        {
           
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            
        }

        private void PointBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            
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
