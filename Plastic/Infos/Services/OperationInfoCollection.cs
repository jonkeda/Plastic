using Plastic.Definitions.Services;

namespace Plastic.Infos.Services
{
    public class OperationInfoCollection : InfoCollection<OperationInfo, OperationDefinition, ServiceInfo>
    {
        public OperationInfoCollection(ServiceInfo parent) : base(parent)
        {
        }

        public void SetRef(ApplicationInfo applicationInfo, ServiceInfo databaseInfo)
        {
            foreach (OperationInfo tableInfo in this)
            {
                tableInfo.SetRef(applicationInfo, databaseInfo);
            }
        }

        public void SetAdd(ApplicationInfo applicationInfo, ServiceInfo databaseInfo)
        {
            foreach (OperationInfo tableInfo in this)
            {
                tableInfo.SetAdd(applicationInfo, databaseInfo);
            }
        }
    }
}