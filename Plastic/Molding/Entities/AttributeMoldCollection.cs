using Plastic.Infos.Entities;

namespace Plastic.Molding.Entities
{
    public abstract class AttributeMoldCollection<T> : MoldCollection<T, IAttributeInfo>
        where T : IAttributeMold
    { }
}