using System.Xml.Serialization;

namespace Plastic.Definitions.Entities
{
    [XmlType("Bool")]
    public class BoolAttributeDefinition : NumberAttributeDefinition<bool>
    {
        public BoolAttributeDefinition()
        {
        }

        public BoolAttributeDefinition(string name) : base(name)
        {
        }

    }
}