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
            foreach (ModelInfo model in this)
            {
                model.SetRef(applicationInfo);
            }
        }

        public void SetAdd(ApplicationInfo applicationInfo)
        {
            foreach (ModelInfo model in this)
            {
                model.SetAdd(applicationInfo);
            }
        }

        public void OrderEntities()
        {
            foreach (ModelInfo model in this)
            {
                model.OrderEntities();
            }
        }
    }
}