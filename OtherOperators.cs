using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Calculator
{
    class OtherOperators : OperatorClass
    {
        public void Multiply()
        {
            SecondValue = Double.Parse(Num2).ToString();
            Num2 = (Double.Parse(FirstValue) * Double.Parse(SecondValue)).ToString();
        }

        public void Divide()
        {
            SecondValue = Double.Parse(Num2).ToString();
            Num2 = (Double.Parse(FirstValue) / Double.Parse(SecondValue)).ToString();
        }
    }
}
