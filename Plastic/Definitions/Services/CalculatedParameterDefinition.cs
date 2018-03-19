using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("CalculatedParameter")]
    public class CalculatedParameterDefinition : ParameterDefinition<string>
    {
        public CalculatedParameterDefinition()
        { }

        public CalculatedParameterDefinition(string name) 
            : base(name)
        { }
    }
}