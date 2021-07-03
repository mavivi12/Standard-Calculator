using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Calculator
{
    class OperatorClass
    {
        String firstValue = "";
        String num2;
        String operation = "";
        Boolean isOperationPressed = false;
        String secondValue;
        String display;

        public string FirstValue { get => firstValue; set => firstValue = value; }
        public string Operation { get => operation; set => operation = value; }
        public bool IsOperationPressed { get => isOperationPressed; set => isOperationPressed = value; }
        public string Num2 { get => num2; set => num2 = value; }
        public string SecondValue { get => secondValue; set => secondValue = value; }
        public string Display { get => display; set => display = value; }

        public void Add()
        {
            secondValue = Double.Parse(num2).ToString();
            num2 = (Double.Parse(firstValue) + Double.Parse(secondValue)).ToString();
        }

        public void Subtract()
        {
            secondValue = Double.Parse(num2).ToString();
            num2 = (Double.Parse(firstValue) - Double.Parse(secondValue)).ToString();
        }
    }
}