using System;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorFactory<RealNumber> realNum = new CalculatorFactory<RealNumber>();
            IOperations<RealNumber> operation = realNum.getOperation("+");
            Console.WriteLine(operation.calculate(new RealNumber(1),
                new RealNumber(2)).num);

            CalculatorFactory<ComplexNumber> compNum = new CalculatorFactory<ComplexNumber>
                ();
            IOperations<ComplexNumber> operation1 = compNum.getOperation("+");
            Console.Write(operation1.calculate(
                new ComplexNumber(2,3),new ComplexNumber(4,5)).realNum + "+");
            Console.Write(operation1.calculate(
                new ComplexNumber(2, 3), new ComplexNumber(4, 5)).imgNum + "i\n");

            CalculatorFactory<VectorNumber> vectorNum = new CalculatorFactory<VectorNumber>();
            IOperations<VectorNumber> operation2 = vectorNum.getOperation("+");
            Console.Write(operation2.calculate(new VectorNumber(2, 3, 4),
                new VectorNumber(2, 3, 4)).u + "i+");
            Console.Write(operation2.calculate(new VectorNumber(2, 3, 4),
                new VectorNumber(2, 3, 4)).v + "j+");
            Console.Write(operation2.calculate(new VectorNumber(2, 3, 4),
                new VectorNumber(2, 3, 4)).w + "k");
        }
    }
}
