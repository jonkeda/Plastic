using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("EnumField")]
    public class EnumerationFieldDefinition : FieldDefinition<int>
    {
        public EnumerationFieldDefinition()
        {
        }

        public EnumerationFieldDefinition(string name) : base(name)
        {
        }

        [XmlAttribute]
        public string EmptyText { get; set; }

        [XmlAttribute]
        public string EnumerationName { get; set; }
    }
}