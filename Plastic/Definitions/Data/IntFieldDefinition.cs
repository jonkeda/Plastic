using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("IntField")]
    public class IntFieldDefinition : NumberFieldDefinition<int>
    {
        public IntFieldDefinition()
        {
        }

        public IntFieldDefinition(string name) : base(name)
        {
        }

    }
}