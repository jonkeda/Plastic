using Plastic.Definitions.Entities;

namespace Plastic.Infos.Entities
{
    public class ModelInfo : Info<ModelDefinition, ApplicationInfo>
    {
        public ModelInfo()
        {
            Entities = new EntityInfoCollection(this);
        }

        public EntityInfoCollection Entities { get; }

        protected override void OnSet(ModelDefinition definition)
        {
            Entities.Set(definition.Entities);
        }

        public void SetRef(ApplicationInfo applicationInfo)
        {
            Entities.SetRef(applicationInfo, this);
        }

        public void SetAdd(ApplicationInfo applicationInfo)
        {
            Entities.SetAdd(applicationInfo, this);
        }
    }
}