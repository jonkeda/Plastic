namespace Plastic.Definitions.Services
{
    public class ServiceDefinitionCollection : DefinitionCollection<ServiceDefinition, ApplicationDefinition>
    {
        public ServiceDefinitionCollection(ApplicationDefinition parent) : base(parent)
        {
        }
    }
}