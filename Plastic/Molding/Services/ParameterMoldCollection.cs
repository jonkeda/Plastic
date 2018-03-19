using Plastic.Infos.Services;

namespace Plastic.Molding.Services
{
    public abstract class ParameterMoldCollection<T> : MoldCollection<T, IParameterInfo>
        where T : IParameterMold
    { }
}