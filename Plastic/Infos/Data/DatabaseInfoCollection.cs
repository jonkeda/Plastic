using Plastic.Definitions.Data;

namespace Plastic.Infos.Data
{
    public class DatabaseInfoCollection : InfoCollection<DatabaseInfo, DatabaseDefinition, ApplicationInfo>
    {
        public DatabaseInfoCollection(ApplicationInfo parent) : base(parent)
        {
        }

        public void SetRef(ApplicationInfo applicationInfo)
        {
            foreach (DatabaseInfo database in this)
            {
                database.SetRef(applicationInfo);
            }
        }

        public void SetAdd(ApplicationInfo applicationInfo)
        {
            foreach (DatabaseInfo database in this)
            {
                database.SetAdd(applicationInfo);
            }
        }
    }
}