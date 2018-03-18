using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    public abstract class NumberFieldDefinition<T> : FieldDefinition<T>
        where T : struct 
    {
        protected NumberFieldDefinition()
        {
        }

        protected NumberFieldDefinition(string name) : base(name)
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