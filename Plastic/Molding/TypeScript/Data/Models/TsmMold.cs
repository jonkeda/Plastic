using Plastic.Infos;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public abstract class TsmMold<T> : Mold, IMold<T>
        where T : IInfo
    {

    }
}