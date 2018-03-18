using System;
using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("DateTimeField")]
    public class DateTimeFieldDefinition : FieldDefinition<DateTime>
    {
        public DateTimeFieldDefinition()
        {
        }

        public DateTimeFieldDefinition(string name) : base(name)
        {
        }

        [XmlAttribute]
        public DateTimeType Type { get; set; }


        [XmlIgnore]
        public bool TypeSpecified { get; set; }

    }
}