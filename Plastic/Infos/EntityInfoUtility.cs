using Plastic.Infos.Entities;

namespace Plastic.Infos
{
    public class EntityInfoUtility
    {
        private static readonly EntityInfo StringInfo = new EntityInfo
        {
            Name = "string"
        };

        public static EntityInfo GetEntityInfo(EntityInfoCollection entities, string entityName)
        {
            EntityInfo entityInfo = entities.GetByName(entityName);
            if (entityInfo == null)
            {
                if (entityName == "string")
                {
                    return StringInfo;
                }
            }

            return entityInfo;
        }
    }
}
