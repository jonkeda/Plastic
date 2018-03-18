using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("MultipleField")]
    public class MultipleFieldDefinition : FieldDefinition<string>
    {
        public MultipleFieldDefinition()
        { }

        public MultipleFieldDefinition(string name) : base(name)
        { }

        [XmlAttribute]
        public string ParentTable { get; set; }
    }
}