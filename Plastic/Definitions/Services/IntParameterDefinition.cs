using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("IntParameter")]
    public class IntParameterDefinition : NumberParameterDefinition<int>
    {
        public IntParameterDefinition()
        {
        }

        public IntParameterDefinition(string name) : base(name)
        {
        }

    }
}