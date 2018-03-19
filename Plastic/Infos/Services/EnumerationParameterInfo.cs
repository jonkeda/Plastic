using Plastic.Definitions.Services;
using Plastic.Infos.Views;

namespace Plastic.Infos.Services
{
    public class EnumerationParameterInfo : ParameterInfo<EnumerationParameterDefinition>
    {
        public EnumerationParameterInfo() : base("")
        { }

        public string EnumerationName { get; set; }
        public EnumerationInfo EnumerationInfo { get; set; }

        protected override void OnSet(EnumerationParameterDefinition definition)
        {
            base.OnSet(definition);

            EnumerationName = definition.EnumerationName;
        }

        public override void SetRef(ApplicationInfo applicationInfo, ServiceInfo databaseInfo, OperationInfo table)
        {
            EnumerationInfo = applicationInfo.Enumerations.GetByName(EnumerationName);
        }

        public override ControlInfo CreateControl()
        {
            return new EnumerationControlInfo();
        }
    }
}