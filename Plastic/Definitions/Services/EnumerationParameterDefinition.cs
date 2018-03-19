using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("EnumParameter")]
    public class EnumerationParameterDefinition : ParameterDefinition<int>
    {
        public EnumerationParameterDefinition()
        {
        }

        public EnumerationParameterDefinition(string name) : base(name)
        {
        }

        [XmlAttribute]
        public string EnumerationName { get; set; }
    }
}