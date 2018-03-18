namespace Plastic.Definitions.Data
{
    public class FieldDefinitionCollection : DefinitionCollection<FieldDefinition, TableDefinition>
    {
        public FieldDefinitionCollection(TableDefinition parent) : base(parent)
        {
        }
    }
}