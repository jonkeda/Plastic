using System;
using System.Linq;
using Plastic.Definitions.Data;

namespace Plastic.Infos.Data
{
    public class TableInfo : Info<TableDefinition, DatabaseInfo>
    {
        public TableInfo()
        {
            Fields = new FieldInfoCollection(this);
        }

        public string Plural { get; set; }

        public FieldInfoCollection Fields { get; }
        public bool Abstract { get; set; }
        public string ParentTable { get; set; }
        public TableInfo ParentTableInfo { get; set; }
        public Crud Crud { get; set; }

        public IFieldInfo Key
        {
            get
            {
                if (ParentTableInfo != null)
                {
                    return ParentTableInfo.Key;
                }
                return Fields.FirstOrDefault(i => i.Key > 0
                    || string.Equals(i.Name, $"{Name}", StringComparison.InvariantCultureIgnoreCase));
            }
        }

        protected override void OnSet(TableDefinition definition)
        {
            Fields.Set(definition.Fields);

            if (string.IsNullOrEmpty(definition.Plural))
            {
                Plural = definition.Name + "s";
            }
            else
            {
                Plural = definition.Plural;
            }

            Abstract = definition.Abstract;
            ParentTable = definition.ParentTable;
            Crud = definition.Crud;
        }

        public void SetRef(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo)
        {
            ParentTableInfo = databaseInfo.Tables.FirstOrDefault(i => i.Name == ParentTable);

            foreach (IFieldInfo field in Fields)
            {
                field.SetRef(applicationInfo, databaseInfo, this);
            }
        }

        public void SetAdd(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo)
        {
            foreach (IFieldInfo field in Fields)
            {
                field.SetAdd(applicationInfo, databaseInfo, this);
            }
        }
    }
}