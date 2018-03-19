using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("BoolParameter")]
    public class BoolParameterDefinition : NumberParameterDefinition<bool>
    {
        public BoolParameterDefinition()
        {
        }

        public BoolParameterDefinition(string name) : base(name)
        {
        }

    }
}