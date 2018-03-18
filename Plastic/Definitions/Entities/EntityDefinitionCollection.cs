namespace Plastic.Definitions.Entities
{
    public class EntityDefinitionCollection : DefinitionCollection<EntityDefinition, ModelDefinition>
    {
        public EntityDefinitionCollection(ModelDefinition parent) : base(parent)
        {
        }
    }
}