namespace Plastic.Definitions.Data
{
    public class DatabaseDefinitionCollection : DefinitionCollection<DatabaseDefinition, ApplicationDefinition>
    {
        public DatabaseDefinitionCollection(ApplicationDefinition parent) : base(parent)
        {
        }
    }
}