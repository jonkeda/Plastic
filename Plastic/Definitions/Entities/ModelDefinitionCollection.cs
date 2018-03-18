namespace Plastic.Definitions.Entities
{
    public class ModelDefinitionCollection : DefinitionCollection<ModelDefinition, ApplicationDefinition>
    {
        public ModelDefinitionCollection(ApplicationDefinition parent) : base(parent)
        {
        }
    }
}