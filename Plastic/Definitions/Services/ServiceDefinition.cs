using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("Service")]
    public class ServiceDefinition : Definition<ApplicationDefinition>
    {
        public ServiceDefinition()
        {
            Operations = new OperationDefinitionCollection(this);
        }

        [XmlElement("Operation")]
        public OperationDefinitionCollection Operations { get; }

        public OperationDefinition AddOperation(OperationDefinition anOperation)
        {
            Operations.Add(anOperation);
            return anOperation;
        }
    }
}