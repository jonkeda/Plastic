using Plastic.Infos.Services;

namespace Plastic.Molding.Services
{
    public abstract class ServiceMoldCollection<T> : MoldCollection<T, OperationInfo>
        where T : IOperationMold
    { }
}