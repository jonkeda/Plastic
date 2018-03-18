using Plastic.Definitions.Data;

namespace Plastic.Infos.Data
{
    public class FieldInfoCollection : InfosCollection<IFieldInfo, FieldDefinition, TableInfo>
    {
        public FieldInfoCollection(TableInfo parent) : base(parent)
        {
        }

        protected override void AddTypes()
        {
            AddType<IntFieldInfo>();
            AddType<DateTimeFieldInfo>();
            AddType<CalculatedFieldInfo>();
            AddType<DecimalFieldInfo>();
            AddType<MultipleFieldInfo>();
            AddType<EnumerationFieldInfo>();
            AddType<ParentFieldInfo>();
            AddType<StringFieldInfo>();
        }
    }
}