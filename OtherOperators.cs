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
            SecondValue = float.Parse(Num2).ToString();
            Num2 = (float.Parse(FirstValue) * float.Parse(SecondValue)).ToString();
        }

        public void Divide()
        {
            SecondValue = float.Parse(Num2).ToString();
            Num2 = (float.Parse(FirstValue) / float.Parse(SecondValue)).ToString();
        }
    }
}