using System;
using System.Linq;
using Plastic.Definitions.Data;
using Plastic.Definitions.Entities;

namespace Plastic.Infos.Entities
{
    public class EntityInfo : Info<EntityDefinition, ModelInfo>
    {
        public EntityInfo()
        {
            Attributes = new AttributeInfoCollection(this);
        }

        public string Plural { get; set; }

        public AttributeInfoCollection Attributes { get; }
        public bool Abstract { get; set; }
        public string ParentEntity { get; set; }
        public EntityInfo ParentEntityInfo { get; set; }
        public Crud Crud { get; set; }

        internal int Order { get; set; }

        public IAttributeInfo Key
        {
            get
            {
                if (ParentEntityInfo != null)
                {
                    return ParentEntityInfo.Key;
                }
                return Attributes.FirstOrDefault(i => i.Key > 0
                    || string.Equals(i.Name, $"{Name}", StringComparison.InvariantCultureIgnoreCase));
            }
        }


        protected override void OnSet(EntityDefinition definition)
        {
            Attributes.Set(definition.Attributes);

            if (string.IsNullOrEmpty(definition.Plural))
            {
                Plural = definition.Name + "s";
            }
            else
            {
                Plural = definition.Plural;
            }

            Abstract = definition.Abstract;
            ParentEntity = definition.ParentEntity;
            Crud = definition.Crud;
        }

        public void SetRef(ApplicationInfo applicationInfo, ModelInfo databaseInfo)
        {
            ParentEntityInfo = databaseInfo.Entities.FirstOrDefault(i => i.Name == ParentEntity);

            foreach (IAttributeInfo field in Attributes)
            {
                field.SetRef(applicationInfo, databaseInfo, this);
            }
        }

        public void SetAdd(ApplicationInfo applicationInfo, ModelInfo databaseInfo)
        {
            foreach (IAttributeInfo field in Attributes)
            {
                field.SetAdd(applicationInfo, databaseInfo, this);
            }
        }
    }
}