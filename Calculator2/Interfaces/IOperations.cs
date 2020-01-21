using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2
{
    interface IOperations<T>
    {
        public T calculate(T a, T b);
    }
}
