using Plastic.Infos.Entities;

namespace Plastic.Molding.Entities
{
    public abstract class ModelMoldCollection<T> : MoldCollection<T, ModelInfo>
        where T : IModelMold
    { }
}