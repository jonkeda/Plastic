using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("StringParameter")]
    public class StringParameterDefinition : ParameterDefinition<string>
    {
        public StringParameterDefinition()
        {
        }

        public StringParameterDefinition(string name) : base(name)
        {
        }

 
    }
}