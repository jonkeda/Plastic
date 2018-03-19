using Plastic.Definitions.Services;

namespace Plastic.Infos.Services
{
    public interface IParameterInfo : IInfo<ParameterDefinition, OperationInfo>
    {
        void SetRef(ApplicationInfo applicationInfo, ServiceInfo databaseInfo, OperationInfo table);
        void SetAdd(ApplicationInfo applicationInfo, ServiceInfo databaseInfo, OperationInfo table);
    }
}