using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("ParentField")]
    public class ParentFieldDefinition : FieldDefinition<string>
    {
        public ParentFieldDefinition()
        { }

        public ParentFieldDefinition(string name) : base(name)
        { }

        [XmlAttribute]
        public string ParentTable { get; set; }
    }
}