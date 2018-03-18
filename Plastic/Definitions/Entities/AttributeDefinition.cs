using System.Xml.Serialization;
using Plastic.Definitions.Data;

namespace Plastic.Definitions.Entities
{
    public abstract class AttributeDefinition : Definition<EntityDefinition>
    {
        protected AttributeDefinition()
        { }

        protected AttributeDefinition(string name) : base(name)
        { }

        [XmlAttribute]
        public int Key { get; set; }

        [XmlIgnore]
        public bool KeySpecified { get; set; }

        [XmlAttribute]
        public bool Required { get; set; }

        [XmlIgnore]
        public bool RequiredSpecified { get; set; }

        [XmlAttribute]
        public string ColumnName { get; set; }

        [XmlAttribute]
        public Crud Crud { get; set; } = Crud.All;

        [XmlIgnore]
        public bool CrudSpecified { get; set; }

    }

    public abstract class AttributeDefinition<T> : AttributeDefinition
    {
        protected AttributeDefinition()
        { }

        protected AttributeDefinition(string name) : base(name)
        { }
    }
}