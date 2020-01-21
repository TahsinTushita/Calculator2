using System;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorFactory<RealNumber> realnum = new CalculatorFactory<RealNumber>();
            IOperations<RealNumber> operation = realnum.getOperation("+");
            Console.WriteLine(operation.calculate(new RealNumber(1),
                new RealNumber(2)).num);

            CalculatorFactory<ComplexNumber> compnum = new CalculatorFactory<ComplexNumber>
                ();
            IOperations<ComplexNumber> operation1 = compnum.getOperation("+");
            Console.Write(operation1.calculate(
                new ComplexNumber(2,3),new ComplexNumber(4,5)).num1 + "+");
            Console.Write(operation1.calculate(
                new ComplexNumber(2, 3), new ComplexNumber(4, 5)).num2 + "i");
        }
    }
}
