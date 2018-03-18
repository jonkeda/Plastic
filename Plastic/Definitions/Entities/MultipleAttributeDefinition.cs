using System.Xml.Serialization;

namespace Plastic.Definitions.Entities
{
    [XmlType("Multiple")]
    public class MultipleAttributeDefinition : AttributeDefinition<string>
    {
        public MultipleAttributeDefinition()
        { }

        public MultipleAttributeDefinition(string name) : base(name)
        { }

        [XmlAttribute]
        public string ChildEntity { get; set; }
    }
}