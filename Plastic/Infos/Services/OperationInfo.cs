using Plastic.Definitions.Services;
using Plastic.Infos.Entities;

namespace Plastic.Infos.Services
{
    public class OperationInfo : Info<OperationDefinition, ServiceInfo>
    {
        public OperationInfo()
        {
            Parameters = new ParameterInfoCollection(this);
        }

        public string ResponseEntity { get; set; }
        public EntityInfo ResponseEntityInfo { get; set; }

        public ParameterInfoCollection Parameters { get; }


        protected override void OnSet(OperationDefinition definition)
        {
            ResponseEntity = definition.ResponseEntity;
            Parameters.Set(definition.Parameters);
        }

        public void SetRef(ApplicationInfo applicationInfo, ServiceInfo databaseInfo)
        {
            ResponseEntityInfo = EntityInfoUtility.GetEntityInfo(applicationInfo, ResponseEntity);
            foreach (IParameterInfo field in Parameters)
            {
                field.SetRef(applicationInfo, databaseInfo, this);
            }
        }

        public void SetAdd(ApplicationInfo applicationInfo, ServiceInfo databaseInfo)
        {
            foreach (IParameterInfo field in Parameters)
            {
                field.SetAdd(applicationInfo, databaseInfo, this);
            }
        }
    }
}