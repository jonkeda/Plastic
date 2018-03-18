using Plastic.Infos.Data;

namespace Plastic.Molding.Data
{
    public abstract class DatabaseMoldCollection<T> : MoldCollection<T, DatabaseInfo>
        where T : IDatabaseMold
    { }
}