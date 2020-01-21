using System;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            IOperations operation = user.chooseOperation("+");
            Console.WriteLine(operation.calculate(2, 3));
        }
    }
}
