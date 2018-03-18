using System.Xml.Serialization;

namespace Plastic.Definitions.Enumerations
{
    [XmlType("Value")]
    public class ValueDefinition : Definition<EnumerationDefinition>
    {
        public ValueDefinition()
        {
        }

        public ValueDefinition(string name) : base(name)
        {
        }
    }

    public class ValueDefinitionCollection : DefinitionCollection<ValueDefinition, EnumerationDefinition>
    {
        public ValueDefinitionCollection(EnumerationDefinition enumerationDefinition) : base(enumerationDefinition)
        {
        }
    }

    [XmlType("Enumeration")]
    public class EnumerationDefinition : Definition<ApplicationDefinition>
    {
        public EnumerationDefinition()
        {
            Values = new ValueDefinitionCollection(this);
        }

        public EnumerationDefinition(string name) : base(name)
        {
            Values = new ValueDefinitionCollection(this);
        }

        [XmlElement("Value")]
        public ValueDefinitionCollection Values { get; }

        public void AddValue(string name)
        {
            Values.Add(new ValueDefinition(name));
        }
    }

    public class EnumerationDefinitionCollection : DefinitionCollection<EnumerationDefinition, ApplicationDefinition>
    {
        public EnumerationDefinitionCollection(ApplicationDefinition parent) : base(parent)
        {
        }
    }
}
