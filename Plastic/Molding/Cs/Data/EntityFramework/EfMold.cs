using Plastic.Infos;

namespace Plastic.Molding.Cs.Data.EntityFramework
{
    public abstract class EfMold<T> : Mold, IMold<T>
        where T : IInfo
    {

    }
}