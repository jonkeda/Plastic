using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("Operation")]
    public class OperationDefinition : Definition<ServiceDefinition>
    {
        public OperationDefinition()
        {
            Parameters = new ParameterDefinitionCollection(this);
        }

        public OperationDefinition(string name) : base(name)
        {
            Parameters = new ParameterDefinitionCollection(this);
        }

        public T AddParameter<T>(T field)
            where T : ParameterDefinition
        {
            Parameters.Add(field);
            return field;
        }

        [XmlElement("Bool", typeof(BoolParameterDefinition))]
        [XmlElement("Calculated", typeof(CalculatedParameterDefinition))]
        [XmlElement("Entity", typeof(EntityParameterDefinition))]
        [XmlElement("DateTime", typeof(DateTimeParameterDefinition))]
        [XmlElement("Decimal", typeof(DecimalParameterDefinition))]
        [XmlElement("Enumeration", typeof(EnumerationParameterDefinition))]
        [XmlElement("Int", typeof(IntParameterDefinition))]
        [XmlElement("Multiple", typeof(MultipleParameterDefinition))]
        [XmlElement("String", typeof(StringParameterDefinition))]
        public ParameterDefinitionCollection Parameters { get; }

        [XmlAttribute]
        public string ResponseEntity { get; set; }
    }
}