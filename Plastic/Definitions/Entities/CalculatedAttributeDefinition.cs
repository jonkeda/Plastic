using System.Xml.Serialization;

namespace Plastic.Definitions.Entities
{
    [XmlType("Calculated")]
    public class CalculatedAttributeDefinition : AttributeDefinition<string>
    {
        public CalculatedAttributeDefinition()
        { }

        public CalculatedAttributeDefinition(string name) 
            : base(name)
        { }
    }
}