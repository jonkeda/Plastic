using Plastic.Definitions.Data;

namespace Plastic.Infos.Data
{
    public class TableInfoCollection : InfoCollection<TableInfo, TableDefinition, DatabaseInfo>
    {
        public TableInfoCollection(DatabaseInfo parent) : base(parent)
        {
        }

        public void SetRef(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo)
        {
            foreach (TableInfo tableInfo in this)
            {
                tableInfo.SetRef(applicationInfo, databaseInfo);
            }
        }

        public void SetAdd(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo)
        {
            foreach (TableInfo tableInfo in this)
            {
                tableInfo.SetAdd(applicationInfo, databaseInfo);
            }
        }
    }
}