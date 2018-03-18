using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("Table")]
    public class TableDefinition : Definition<DatabaseDefinition>
    {
        public TableDefinition()
        {
            Fields = new FieldDefinitionCollection(this);
        }

        public TableDefinition(string name) : base(name)
        {
            Fields = new FieldDefinitionCollection(this);
        }

        public T AddField<T>(T field)
            where T : FieldDefinition
        {
            Fields.Add(field);
            return field;
        }

        [XmlElement("Bool", typeof(BoolFieldDefinition))]
        [XmlElement("Calculated", typeof(CalculatedFieldDefinition))]
        [XmlElement("Child", typeof(ChildFieldDefinition))]
        [XmlElement("DateTime", typeof(DateTimeFieldDefinition))]
        [XmlElement("Decimal", typeof(DecimalFieldDefinition))]
        [XmlElement("Enumeration", typeof(EnumerationFieldDefinition))]
        [XmlElement("Int", typeof(IntFieldDefinition))]
        [XmlElement("Multiple", typeof(MultipleFieldDefinition))]
        [XmlElement("Parent", typeof(ParentFieldDefinition))]
        [XmlElement("String", typeof(StringFieldDefinition))]
        public FieldDefinitionCollection Fields { get; }

        [XmlAttribute]
        public string Plural { get; set; }

        [XmlAttribute]
        public bool Abstract { get; set; }

        [XmlIgnore]
        public bool AbstractSpecified { get; set; }

        [XmlAttribute]
        public string ParentTable { get; set; }

        [XmlAttribute]
        public Crud Crud { get; set; } = Crud.All;

        [XmlIgnore]
        public bool CrudSpecified { get; set; }
    }
}