using System.Xml.Serialization;

namespace Plastic.Definitions.Entities
{
    [XmlType("Enum")]
    public class EnumerationAttributeDefinition : AttributeDefinition<int>
    {
        public EnumerationAttributeDefinition()
        {
        }

        public EnumerationAttributeDefinition(string name) : base(name)
        {
        }

        [XmlAttribute]
        public string EmptyText { get; set; }

        [XmlAttribute]
        public string EnumerationName { get; set; }
    }
}