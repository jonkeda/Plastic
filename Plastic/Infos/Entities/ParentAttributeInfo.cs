using System.Xml.Serialization;
using Plastic.Definitions.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public class ParentAttributeInfo : AttributeInfo<ParentAttributeDefinition, string>
    {
        public ParentAttributeInfo() : base("int")
        {
        }

        public string ParentEntity { get; set; }

        [XmlIgnore]
        public EntityInfo ParentEntityInfo { get; set; }

        protected override void OnSet(ParentAttributeDefinition definition)
        {
            base.OnSet(definition);
            ParentEntity = definition.ParentEntity;
        }

        public override void SetRef(ApplicationInfo applicationInfo, ModelInfo databaseInfo, EntityInfo table)
        {
            ParentEntityInfo = EntityInfoUtility.GetEntityInfo(databaseInfo.Entities, ParentEntity);
        }

        public override ControlInfo CreateControl()
        {
            return new ParentControlInfo();
        }
    }
}