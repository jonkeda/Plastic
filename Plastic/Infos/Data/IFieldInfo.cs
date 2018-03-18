using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public interface IFieldInfo : IInfo<FieldDefinition, TableInfo>
    {
        int Key { get; }
        string DisplayName { get; }
        string ColumnName { get; }
        bool Required { get; }
        string TypeName { get; }
        Crud Crud { get; }

        void SetRef(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo, TableInfo table);
        void SetAdd(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo, TableInfo table);
        ControlInfo CreateControl();
    }
}