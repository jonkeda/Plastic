using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("ChildField")]
    public class ChildFieldDefinition : FieldDefinition<string>
    {
        public ChildFieldDefinition()
        { }

        public ChildFieldDefinition(string name) : base(name)
        { }

        [XmlAttribute]
        public string ChildTable { get; set; }
    }
}