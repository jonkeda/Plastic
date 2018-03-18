using Plastic.Infos.Data;

namespace Plastic.Molding.Data
{
    public abstract class FieldMoldCollection<T> : MoldCollection<T, IFieldInfo>
        where T : IFieldMold
    { }
}