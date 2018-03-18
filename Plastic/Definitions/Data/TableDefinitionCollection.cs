namespace Plastic.Definitions.Data
{
    public class TableDefinitionCollection : DefinitionCollection<TableDefinition, DatabaseDefinition>
    {
        public TableDefinitionCollection(DatabaseDefinition parent) : base(parent)
        {
        }
    }
}