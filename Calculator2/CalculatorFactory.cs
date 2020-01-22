

namespace Calculator2
{
    class CalculatorFactory<T> : IFactory<T> where T: ITypes
    {
        public IOperations<T> getOperation(string choice)
        {
            switch(choice)
            {
                case "+":
                    return new Addition<T>();
                    break;

                case "-":
                    return new Subtraction<T>();
                    break;

                case "*":
                    return new Multiplication<T>();
                    break;

                case "/":
                    return new Division<T>();
                    break;

                default:
                    return default;
            }
        }
    }
}
