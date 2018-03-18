using Plastic.Definitions.Entities;

namespace Plastic.Infos.Entities
{
    public class ModelInfoCollection : InfoCollection<ModelInfo, ModelDefinition, ApplicationInfo>
    {
        public ModelInfoCollection(ApplicationInfo parent) : base(parent)
        {
        }

        public void SetRef(ApplicationInfo applicationInfo)
        {
            foreach (ModelInfo database in this)
            {
                database.SetRef(applicationInfo);
            }
        }

        public void SetAdd(ApplicationInfo applicationInfo)
        {
            foreach (ModelInfo database in this)
            {
                database.SetAdd(applicationInfo);
            }
        }
    }
}