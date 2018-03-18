using Plastic.Definitions.Data;
using Plastic.Definitions.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public interface IAttributeInfo : IInfo<AttributeDefinition, EntityInfo>
    {
        int Key { get; }
        string DisplayName { get; }
        string ColumnName { get; }
        bool Required { get; }
        string TypeName { get; }
        Crud Crud { get; }

        void SetRef(ApplicationInfo applicationInfo, ModelInfo databaseInfo, EntityInfo table);
        void SetAdd(ApplicationInfo applicationInfo, ModelInfo databaseInfo, EntityInfo table);
        ControlInfo CreateControl();
    }
}