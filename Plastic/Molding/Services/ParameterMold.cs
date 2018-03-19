using Plastic.Infos.Services;

namespace Plastic.Molding.Services
{
    public class ParameterMold<T> : Mold<T>, IParameterMold
        where T : IParameterInfo
    { }
}