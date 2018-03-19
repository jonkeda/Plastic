using Plastic.Definitions.Services;

namespace Plastic.Infos.Services
{
    public class ServiceInfo : Info<ServiceDefinition, ApplicationInfo>
    {
        public ServiceInfo()
        {
            Operations = new OperationInfoCollection(this);
        }

        public OperationInfoCollection Operations { get; }

        protected override void OnSet(ServiceDefinition definition)
        {
            Operations.Set(definition.Operations);
        }

        public void SetRef(ApplicationInfo applicationInfo)
        {
            Operations.SetRef(applicationInfo, this);
        }

        public void SetAdd(ApplicationInfo applicationInfo)
        {
            Operations.SetAdd(applicationInfo, this);
        }
    }
}