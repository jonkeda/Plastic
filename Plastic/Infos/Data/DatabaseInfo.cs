using Plastic.Definitions.Data;

namespace Plastic.Infos.Data
{
    public class DatabaseInfo : Info<DatabaseDefinition, ApplicationInfo>
    {
        public DatabaseInfo()
        {
            Tables = new TableInfoCollection(this);
        }

        public TableInfoCollection Tables { get; }

        protected override void OnSet(DatabaseDefinition definition)
        {
            Tables.Set(definition.Tables);
        }

        public void SetRef(ApplicationInfo applicationInfo)
        {
            Tables.SetRef(applicationInfo, this);
        }

        public void SetAdd(ApplicationInfo applicationInfo)
        {
            Tables.SetAdd(applicationInfo, this);
        }
    }
}