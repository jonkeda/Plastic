using Plastic.Infos.Entities;

namespace Plastic.Molding.Entities
{
    public class AttributeMold<T> : Mold<T>, IAttributeMold
        where T : IAttributeInfo
    { }
}