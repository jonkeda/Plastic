using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("DecimalField")]
    public class DecimalFieldDefinition : NumberFieldDefinition<decimal>
    {
        public DecimalFieldDefinition()
        {
        }

        public DecimalFieldDefinition(string name) : base(name)
        {
        }
    }
}