using System.Xml.Serialization;

namespace Plastic.Definitions.Entities
{
    [XmlType("Child")]
    public class ChildAttributeDefinition : AttributeDefinition<string>
    {
        public ChildAttributeDefinition()
        { }

        public ChildAttributeDefinition(string name) : base(name)
        { }

        [XmlAttribute]
        public string ChildEntity { get; set; }
    }
}