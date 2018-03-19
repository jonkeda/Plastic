using Plastic.Infos.Services;

namespace Plastic.Molding.Services
{
    public abstract class ServiceInterfaceMoldCollection<T> : MoldCollection<T, ServiceInfo>
        where T : IServiceInterfaceMold
    { }
}