using Plastic.Infos;

namespace Plastic.Molding
{
    public interface IMold
    { }

    public interface IMold<T> : IMold
        where T : IInfo
    { }

    public abstract class Mold : IMold
    {
    }

    public abstract class Mold<T> : Mold, IMold<T>
        where T : IInfo
    {
        
    }
}
