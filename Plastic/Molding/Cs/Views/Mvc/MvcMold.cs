using Plastic.Infos;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public abstract class MvcMold<T> : Mold, IMold<T>
        where T : IInfo
    {

    }
}