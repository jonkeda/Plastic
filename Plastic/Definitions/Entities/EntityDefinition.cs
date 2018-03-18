using System.Xml.Serialization;
using Plastic.Definitions.Data;

namespace Plastic.Definitions.Entities
{
    [XmlType("Entity")]
    public class EntityDefinition : Definition<ModelDefinition>
    {
        public EntityDefinition()
        {
            Attributes = new AttributeDefinitionCollection(this);
        }

        public EntityDefinition(string name) : base(name)
        {
            Attributes = new AttributeDefinitionCollection(this);
        }

        public T AddAttribute<T>(T field)
            where T : AttributeDefinition
        {
            Attributes.Add(field);
            return field;
        }

        [XmlElement("Bool", typeof(BoolAttributeDefinition))]
        [XmlElement("Calculated", typeof(CalculatedAttributeDefinition))]
        [XmlElement("Child", typeof(ChildAttributeDefinition))]
        [XmlElement("DateTime", typeof(DateTimeAttributeDefinition))]
        [XmlElement("Decimal", typeof(DecimalAttributeDefinition))]
        [XmlElement("Enumeration", typeof(EnumerationAttributeDefinition))]
        [XmlElement("Int", typeof(IntAttributeDefinition))]
        [XmlElement("Multiple", typeof(MultipleAttributeDefinition))]
        [XmlElement("Parent", typeof(ParentAttributeDefinition))]
        [XmlElement("String", typeof(StringAttributeDefinition))]
        public AttributeDefinitionCollection Attributes { get; }

        [XmlAttribute]
        public string Plural { get; set; }

        [XmlAttribute]
        public bool Abstract { get; set; }

        [XmlIgnore]
        public bool AbstractSpecified { get; set; }

        [XmlAttribute]
        public string ParentEntity { get; set; }

        [XmlAttribute]
        public Crud Crud { get; set; } = Crud.All;

        [XmlIgnore]
        public bool CrudSpecified { get; set; }
    }
}