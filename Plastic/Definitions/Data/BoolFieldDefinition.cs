using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("BoolField")]
    public class BoolFieldDefinition : NumberFieldDefinition<bool>
    {
        public BoolFieldDefinition()
        {
        }

        public BoolFieldDefinition(string name) : base(name)
        {
        }

    }
}