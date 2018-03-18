using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public abstract class EfFieldInfo<T> : Info<T, TableInfo>, IFieldInfo
        where T : FieldDefinition
    {
        protected EfFieldInfo(string typeName)
        {
            TypeName = typeName;
        }

        public int Key { get; set; }
        public bool Required { get; set; }
        public string TypeName { get; }
        public string ColumnName { get; set; }
        public Crud Crud { get; set; }

        protected override void OnSet(T definition)
        {
            base.OnSet(definition);
            Key = definition.Key;
            Required = definition.Required;
            Crud = definition.Crud;
            if (string.IsNullOrEmpty(definition.ColumnName))
            {
                ColumnName = definition.Name;
            }
            else
            {
                ColumnName = definition.ColumnName;
            }
        }

        public virtual void SetRef(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo, TableInfo table)
        {
        }

        public virtual void SetAdd(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo, TableInfo table)
        {
        }

        public abstract ControlInfo CreateControl();
    }

    public abstract class EfFieldInfo<TD, T> : EfFieldInfo<TD>
        where TD : FieldDefinition<T>
    {
        protected EfFieldInfo(string typeName) : base(typeName)
        {
        }
    }

}