using Calculator2.Interfaces;
namespace Calculator2
{
    interface IFactory<T> where T: ITypes
    {
        IOperations<T> getOperation(string operation);
    }
}
