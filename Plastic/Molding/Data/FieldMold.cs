using Plastic.Infos.Data;

namespace Plastic.Molding.Data
{
    public class FieldMold<T> : Mold<T>, IFieldMold
        where T : IFieldInfo
    { }
}