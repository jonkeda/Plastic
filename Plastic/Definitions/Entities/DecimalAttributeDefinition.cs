using System.Xml.Serialization;

namespace Plastic.Definitions.Entities
{
    [XmlType("Decimal")]
    public class DecimalAttributeDefinition : NumberAttributeDefinition<decimal>
    {
        public DecimalAttributeDefinition()
        {
        }

        public DecimalAttributeDefinition(string name) : base(name)
        {
        }
    }
}