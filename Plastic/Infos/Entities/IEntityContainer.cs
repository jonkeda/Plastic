namespace Plastic.Infos.Entities
{
    public interface IEntityContainer : IAttributeInfo
    {
        EntityInfo GetEntity();
    }
}