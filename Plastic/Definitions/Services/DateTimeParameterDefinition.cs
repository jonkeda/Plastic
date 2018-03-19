using System;
using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("DateTimeParameter")]
    public class DateTimeParameterDefinition : ParameterDefinition<DateTime>
    {
        public DateTimeParameterDefinition()
        {
        }

        public DateTimeParameterDefinition(string name) : base(name)
        {
        }
    }
}