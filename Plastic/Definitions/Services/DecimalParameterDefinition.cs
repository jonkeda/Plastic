using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("DecimalParameter")]
    public class DecimalParameterDefinition : NumberParameterDefinition<decimal>
    {
        public DecimalParameterDefinition()
        {
        }

        public DecimalParameterDefinition(string name) : base(name)
        {
        }
    }
}