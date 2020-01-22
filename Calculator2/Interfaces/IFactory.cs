
namespace Calculator2
{
    interface IFactory<T> where T: ITypes
    {
        IOperations<T> getOperation(string operation);
    }
}
