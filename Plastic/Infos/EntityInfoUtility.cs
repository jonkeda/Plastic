using Plastic.Infos.Entities;

namespace Plastic.Infos
{
    public class EntityInfoUtility
    {
        private static readonly EntityInfo StringInfo = new EntityInfo
        {
            Name = "string"
        };

        private static readonly EntityInfo BooleanInfo = new EntityInfo
        {
            Name = "boolean"
        };

        public static EntityInfo GetEntityInfo(ApplicationInfo application, string entityName)
        {
            foreach (ModelInfo model in application.Models)
            {
                EntityInfo entity = model.Entities.GetByName(entityName);
                if (entity != null)
                {
                    return entity;
                }
            }
            return StandardEntityInfo(entityName);
        }


        public static EntityInfo GetEntityInfo(EntityInfoCollection entities, string entityName)
        {
            EntityInfo entityInfo = entities.GetByName(entityName);
            if (entityInfo != null)
            {
                return entityInfo;
            }
            return StandardEntityInfo(entityName);
        }

        private static EntityInfo StandardEntityInfo(string entityName)
        {
            if (entityName == "string")
            {
                return StringInfo;
            }
            if (entityName == "boolean")
            {
                return BooleanInfo;
            }
            return null;
        }
    }
}
