﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2
{
    class Addition<T> : IOperations<T>
    {
        public T calculate(T a, T b)
        {
            dynamic result = (dynamic)a + (dynamic)b;
            return result;
        }
    }
}
