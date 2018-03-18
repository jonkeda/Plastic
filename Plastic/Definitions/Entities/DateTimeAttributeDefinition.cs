using System;
using System.Xml.Serialization;
using Plastic.Definitions.Data;

namespace Plastic.Definitions.Entities
{
    [XmlType("DateTime")]
    public class DateTimeAttributeDefinition : AttributeDefinition<DateTime>
    {
        public DateTimeAttributeDefinition()
        {
        }

        public DateTimeAttributeDefinition(string name) : base(name)
        {
        }

        [XmlAttribute]
        public DateTimeType Type { get; set; }


        [XmlIgnore]
        public bool TypeSpecified { get; set; }

    }
}