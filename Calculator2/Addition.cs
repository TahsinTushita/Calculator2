using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2
{
    class Addition : IOperations
    {
        public double calculate(double a, double b)
        {
            return a + b;
        }
    }
}
