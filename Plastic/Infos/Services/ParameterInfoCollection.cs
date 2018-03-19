using Plastic.Definitions.Services;

namespace Plastic.Infos.Services
{
    public class ParameterInfoCollection : InfosCollection<IParameterInfo, ParameterDefinition, OperationInfo>
    {
        public ParameterInfoCollection(OperationInfo parent) : base(parent)
        {
        }

        protected override void AddTypes()
        {
            AddType<IntParameterInfo>();
            AddType<DateTimeParameterInfo>();
            AddType<CalculatedParameterInfo>();
            AddType<DecimalParameterInfo>();
            AddType<MultipleParameterInfo>();
            AddType<EntityParameterInfo>();
            AddType<EnumerationParameterInfo>();
            AddType<StringParameterInfo>();
        }
    }
}