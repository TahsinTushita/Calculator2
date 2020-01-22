using System;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorFactory<RealNumber> realNum = new CalculatorFactory<RealNumber>();
            IOperations<RealNumber> operation = realNum.getOperation("+");
            Console.WriteLine("result = " + operation.calculate(new RealNumber(1),
                new RealNumber(2)).num);

            CalculatorFactory<ComplexNumber> compNum = new CalculatorFactory<ComplexNumber>
                ();
            IOperations<ComplexNumber> operation1 = compNum.getOperation("+");
            ComplexNumber complexNumber = new ComplexNumber();
            complexNumber = operation1.calculate(
                new ComplexNumber(2, 3), new ComplexNumber(4, 5));
            Console.WriteLine("result = {0}+({1})i",complexNumber.realNum,
                complexNumber.imgNum);

            CalculatorFactory<VectorNumber> vectorNum = new 
                CalculatorFactory<VectorNumber>();
            IOperations<VectorNumber> operation2 = vectorNum.getOperation("*");
            VectorNumber vnum = new VectorNumber();
            vnum = operation2.calculate(new VectorNumber(-2, 1, 4),
                new VectorNumber(6, 2, 1));
            Console.WriteLine("result = {0}i+({1})j+({2})k", vnum.u, vnum.v, vnum.w);
        }
    }
}
