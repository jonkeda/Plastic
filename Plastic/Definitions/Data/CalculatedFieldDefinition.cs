using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("CalculatedField")]
    public class CalculatedFieldDefinition : FieldDefinition<string>
    {
        public CalculatedFieldDefinition()
        { }

        public CalculatedFieldDefinition(string name) 
            : base(name)
        { }
    }
}