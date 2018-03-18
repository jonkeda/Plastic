using Plastic.Definitions.Entities;

namespace Plastic.Infos.Entities
{
    public class EntityInfoCollection : InfoCollection<EntityInfo, EntityDefinition, ModelInfo>
    {
        public EntityInfoCollection(ModelInfo parent) : base(parent)
        {
        }

        public void SetRef(ApplicationInfo applicationInfo, ModelInfo databaseInfo)
        {
            foreach (EntityInfo tableInfo in this)
            {
                tableInfo.SetRef(applicationInfo, databaseInfo);
            }
        }

        public void SetAdd(ApplicationInfo applicationInfo, ModelInfo databaseInfo)
        {
            foreach (EntityInfo tableInfo in this)
            {
                tableInfo.SetAdd(applicationInfo, databaseInfo);
            }
        }
    }
}