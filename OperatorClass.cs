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

        public string FirstValue { get => firstValue; set => firstValue = value; }
        public string Operation { get => operation; set => operation = value; }
        public bool IsOperationPressed { get => isOperationPressed; set => isOperationPressed = value; }
        public string Num2 { get => num2; set => num2 = value; }
        public string SecondValue { get => secondValue; set => secondValue = value; }

        public void Add()
        {
            secondValue = float.Parse(num2).ToString();
            num2 = (float.Parse(firstValue) + float.Parse(secondValue)).ToString();
        }

        public void Subtract()
        {
            secondValue = float.Parse(num2).ToString();
            num2 = (float.Parse(firstValue) - float.Parse(secondValue)).ToString();
        }
    }
}