using Plastic.Definitions.Services;

namespace Plastic.Infos.Services
{
    public class ServiceInfoCollection : InfoCollection<ServiceInfo, ServiceDefinition, ApplicationInfo>
    {
        public ServiceInfoCollection(ApplicationInfo parent) : base(parent)
        {
        }

        public void SetRef(ApplicationInfo applicationInfo)
        {
            foreach (ServiceInfo database in this)
            {
                database.SetRef(applicationInfo);
            }
        }

        public void SetAdd(ApplicationInfo applicationInfo)
        {
            foreach (ServiceInfo database in this)
            {
                database.SetAdd(applicationInfo);
            }
        }
    }
}