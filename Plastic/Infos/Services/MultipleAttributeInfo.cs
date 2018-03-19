using System.Xml.Serialization;
using Plastic.Definitions.Services;
using Plastic.Infos.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Services
{
    public class MultipleParameterInfo : ParameterInfo<MultipleParameterDefinition, string>
    {
        public MultipleParameterInfo() : base("int")
        {
        }

        public string ParentService { get; set; }

        [XmlIgnore]
        public EntityInfo ParentServiceInfo { get; set; }

        protected override void OnSet(MultipleParameterDefinition definition)
        {
            base.OnSet(definition);
            ParentService = definition.ChildEntity;
        }

        public override void SetRef(ApplicationInfo applicationInfo, ServiceInfo databaseInfo, OperationInfo table)
        {
            ParentServiceInfo = EntityInfoUtility.GetEntityInfo(applicationInfo, ParentService);
        }

        public override ControlInfo CreateControl()
        {
            return new MultipleControlInfo();
        }
    }
}