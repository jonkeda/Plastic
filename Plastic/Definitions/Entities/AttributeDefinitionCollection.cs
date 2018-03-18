namespace Plastic.Definitions.Entities
{
    public class AttributeDefinitionCollection : DefinitionCollection<AttributeDefinition, EntityDefinition>
    {
        public AttributeDefinitionCollection(EntityDefinition parent) : base(parent)
        {
        }
    }
}