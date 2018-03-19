using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("MultipleParameter")]
    public class MultipleParameterDefinition : ParameterDefinition<string>
    {
        public MultipleParameterDefinition()
        { }

        public MultipleParameterDefinition(string name) : base(name)
        { }

        [XmlAttribute]
        public string ChildEntity { get; set; }
    }
}