using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2
{
    interface IFactory<T>
    {
        IOperations<T> getOperation(string operation);
    }
}
