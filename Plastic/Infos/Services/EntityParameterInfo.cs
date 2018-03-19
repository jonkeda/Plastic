using System.Xml.Serialization;
using Plastic.Definitions.Services;
using Plastic.Infos.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Services
{
    public class EntityParameterInfo : ParameterInfo<EntityParameterDefinition, string>
    {
        public EntityParameterInfo() : base("int")
        {}

        public string Entity { get; set; }
        [XmlIgnore]
        public EntityInfo EntityInfo { get; set; }

        protected override void OnSet(EntityParameterDefinition definition)
        {
            base.OnSet(definition);
            Entity = definition.Entity;
        }

        public override void SetRef(ApplicationInfo applicationInfo, ServiceInfo databaseInfo, OperationInfo table)
        {
            EntityInfo = EntityInfoUtility.GetEntityInfo(applicationInfo, Entity);
        }

        public override ControlInfo CreateControl()
        {
            return new ChildControlInfo();
        }
    }
}