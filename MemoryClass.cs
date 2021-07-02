using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Calculator
{
    class MemoryClass : OperatorClass
    {
        Double memory = 0;
        Boolean isMemory = false;

        public double Memory { get => memory; set => memory = value; }
        public bool IsMemory { get => isMemory; set => isMemory = value; }
    }
}