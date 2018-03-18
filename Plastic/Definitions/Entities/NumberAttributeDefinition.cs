using System.Xml.Serialization;
using Plastic.Definitions.Data;

namespace Plastic.Definitions.Entities
{
    public abstract class NumberAttributeDefinition<T> : AttributeDefinition<T>
        where T : struct 
    {
        protected NumberAttributeDefinition()
        {
        }

        protected NumberAttributeDefinition(string name) : base(name)
        {
        }

        public T? Minimum { get; set; }

        public T? Maximum { get; set; }

        [XmlAttribute]
        public NumberType Type { get; set; }

        [XmlIgnore]
        public bool NumberTypeSpecified { get; set; }

    }
}