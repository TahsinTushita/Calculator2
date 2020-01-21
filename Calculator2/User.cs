using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2
{
    class User
    {
        public IOperations chooseOperation(string choice)
        {
            switch(choice)
            {
                case "+":
                    return new Addition();
                    break;

                case "-":
                    return new Subtraction();
                    break;

                case "*":
                    return new Multiplication();
                    break;

                case "/":
                    return new Division();
                    break;

                default:
                    return default;
            }
        }
    }
}
