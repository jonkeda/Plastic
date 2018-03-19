namespace Plastic.Definitions.Services
{
    public class OperationDefinitionCollection : DefinitionCollection<OperationDefinition, ServiceDefinition>
    {
        public OperationDefinitionCollection(ServiceDefinition parent) : base(parent)
        {
        }
    }
}