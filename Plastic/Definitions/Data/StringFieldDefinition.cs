using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("StringField")]
    public class StringFieldDefinition : FieldDefinition<string>
    {
        public StringFieldDefinition()
        {
        }

        public StringFieldDefinition(string name) : base(name)
        {
        }

        [XmlAttribute]
        public int Length { get; set; } = -1;

        [XmlIgnore]
        public bool LengthSpecified { get; set; }

        [XmlAttribute]
        public int MinimumLength { get; set; } = -1;

        [XmlIgnore]
        public bool MinimumLengthSpecified { get; set; }

        [XmlAttribute]
        public string LengthErrorMessage { get; set; }
    }
}