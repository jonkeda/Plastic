using System.Xml.Serialization;

namespace Plastic.Definitions.Entities
{
    [XmlType("Model")]
    public class ModelDefinition : Definition<ApplicationDefinition>
    {
        public ModelDefinition()
        {
            Entities = new EntityDefinitionCollection(this);
        }

        [XmlElement("Entity")]
        public EntityDefinitionCollection Entities { get; }

        public EntityDefinition AddEntity(EntityDefinition table)
        {
            Entities.Add(table);
            return table;
        }
    }
}