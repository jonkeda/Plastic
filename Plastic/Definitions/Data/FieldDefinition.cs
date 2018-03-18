using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    public abstract class FieldDefinition : Definition<TableDefinition>
    {
        protected FieldDefinition()
        { }

        protected FieldDefinition(string name) : base(name)
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

    public abstract class FieldDefinition<T> : FieldDefinition
    {
        protected FieldDefinition()
        { }

        protected FieldDefinition(string name) : base(name)
        { }
    }
}