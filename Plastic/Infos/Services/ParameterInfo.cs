using Plastic.Definitions.Services;
using Plastic.Infos.Views;

namespace Plastic.Infos.Services
{
    public abstract class ParameterInfo<TD, T> : ParameterInfo<TD>
        where TD : ParameterDefinition<T>
    {
        protected ParameterInfo(string typeName) : base(typeName)
        {
        }
    }

    public abstract class ParameterInfo<T> : Info<T, OperationInfo>, IParameterInfo
        where T : ParameterDefinition
    {
        protected ParameterInfo(string typeName)
        {
            TypeName = typeName;
        }

        public string TypeName { get; }

        public virtual void SetRef(ApplicationInfo applicationInfo, ServiceInfo databaseInfo, OperationInfo table)
        {
        }

        public virtual void SetAdd(ApplicationInfo applicationInfo, ServiceInfo databaseInfo, OperationInfo table)
        {
        }

        public abstract ControlInfo CreateControl();
    }
}