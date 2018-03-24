using System.Xml.Serialization;
using Plastic.Definitions.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public class ChildAttributeInfo : AttributeInfo<ChildAttributeDefinition, string>, IEntityContainer
    {
        public ChildAttributeInfo() : base("int")
        {}

        public string ChildEntity { get; set; }
        [XmlIgnore]
        public EntityInfo ChildEntityInfo { get; set; }

        public EntityInfo GetEntity()
        {
            return ChildEntityInfo;
        }
        
        protected override void OnSet(ChildAttributeDefinition definition)
        {
            base.OnSet(definition);
            ChildEntity = definition.ChildEntity;
        }

        public override void SetRef(ApplicationInfo applicationInfo, ModelInfo databaseInfo, EntityInfo table)
        {
            ChildEntityInfo = EntityInfoUtility.GetEntityInfo(databaseInfo.Entities, ChildEntity);
        }

        public override ControlInfo CreateControl()
        {
            return new ChildControlInfo();
        }

    }
}