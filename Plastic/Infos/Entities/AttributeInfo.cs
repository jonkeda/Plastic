using Plastic.Definitions.Data;
using Plastic.Definitions.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public abstract class AttributeInfo<T> : Info<T, EntityInfo>, IAttributeInfo
        where T : AttributeDefinition
    {
        protected AttributeInfo(string typeName)
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

        public virtual void SetRef(ApplicationInfo applicationInfo, ModelInfo databaseInfo, EntityInfo table)
        {
        }

        public virtual void SetAdd(ApplicationInfo applicationInfo, ModelInfo databaseInfo, EntityInfo table)
        {
        }

        public abstract ControlInfo CreateControl();
    }

    public abstract class AttributeInfo<TD, T> : AttributeInfo<TD>
        where TD : AttributeDefinition<T>
    {
        protected AttributeInfo(string typeName) : base(typeName)
        {
        }
    }

}