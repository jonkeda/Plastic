using Plastic.Infos;

namespace Plastic.Molding.TypeScript.Data
{
    public abstract class TsMold<T> : Mold, IMold<T>
        where T : IInfo
    {

    }
}