using System.Xml.Serialization;

namespace Plastic.Definitions.Data
{
    [XmlType("Database")]
    public class DatabaseDefinition : Definition<ApplicationDefinition>
    {
        public DatabaseDefinition()
        {
            Tables = new TableDefinitionCollection(this);
        }

        [XmlElement("Table")]
        public TableDefinitionCollection Tables { get; }

        public TableDefinition AddTable(TableDefinition table)
        {
            Tables.Add(table);
            return table;
        }
    }
}