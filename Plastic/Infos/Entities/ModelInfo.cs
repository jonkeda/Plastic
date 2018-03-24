using System;
using System.Collections.Generic;
using System.Linq;
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

        public void OrderEntities()
        {
            int height = 0;
            Stack<EntityInfo> stack = new Stack<EntityInfo>();
            foreach (EntityInfo entity in Entities)
            {
                OrderByAttributes(entity, stack, height + 1);
            }
        }

        private void OrderByAttributes(EntityInfo entity, Stack<EntityInfo> stack, int height)
        {
            if (entity == null
                || stack.Contains(entity))
            {
                return;
            }
            stack.Push(entity);
            if (entity.Order < height)
            {
                entity.Order = height;
            }
            foreach (IEntityContainer info in entity.Attributes.OfType<IEntityContainer>())
            {
                OrderByAttributes(info.GetEntity(), stack, height + 1);                
            }
            OrderByAttributes(entity.ParentEntityInfo, stack, height + 1);
            stack.Pop();
        }
    }
}