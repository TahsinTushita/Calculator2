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
            ComplexNumber cnum = new ComplexNumber();
            cnum = operation1.calculate(
                new ComplexNumber(2, 3), new ComplexNumber(4, 5));
            Console.WriteLine("result = {0}+{1}i",cnum.realNum,cnum.imgNum);

            CalculatorFactory<VectorNumber> vectorNum = new CalculatorFactory<VectorNumber>();
            IOperations<VectorNumber> operation2 = vectorNum.getOperation("+");
            VectorNumber number = new VectorNumber();
            number = operation2.calculate(new VectorNumber(2, 3, 4),
                new VectorNumber(2, 3, 4));

            Console.WriteLine("result = {0}i+{1}j+{2}k", number.u,number.v,number.w);
        }
    }
}
