using System.Xml.Serialization;

namespace Plastic.Definitions.Entities
{
    [XmlType("Int")]
    public class IntAttributeDefinition : NumberAttributeDefinition<int>
    {
        public IntAttributeDefinition()
        {
        }

        public IntAttributeDefinition(string name) : base(name)
        {
        }

    }
}