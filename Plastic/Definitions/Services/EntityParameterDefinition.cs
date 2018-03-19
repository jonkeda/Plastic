using System.Xml.Serialization;

namespace Plastic.Definitions.Services
{
    [XmlType("EntityParameter")]
    public class EntityParameterDefinition : ParameterDefinition<string>
    {
        public EntityParameterDefinition()
        { }

        public EntityParameterDefinition(string name) : base(name)
        { }

        [XmlAttribute]
        public string Entity { get; set; }
    }
}