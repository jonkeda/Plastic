using System.Xml.Serialization;

namespace Plastic.Definitions.Entities
{
    [XmlType("Parent")]
    public class ParentAttributeDefinition : AttributeDefinition<string>
    {
        public ParentAttributeDefinition()
        { }

        public ParentAttributeDefinition(string name) : base(name)
        { }

        [XmlAttribute]
        public string ParentEntity { get; set; }
    }
}