using Plastic.Infos.Entities;

namespace Plastic.Molding.Entities
{
    public abstract class EntityMoldCollection<T> : MoldCollection<T, EntityInfo>
        where T : IEntityMold
    { }
}