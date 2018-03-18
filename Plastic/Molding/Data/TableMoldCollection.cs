using Plastic.Infos.Data;

namespace Plastic.Molding.Data
{
    public abstract class TableMoldCollection<T> : MoldCollection<T, TableInfo>
        where T : ITableMold
    { }
}