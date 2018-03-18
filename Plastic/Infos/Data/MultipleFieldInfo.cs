using System.Xml.Serialization;
using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public class MultipleFieldInfo : EfFieldInfo<MultipleFieldDefinition, string>
    {
        public MultipleFieldInfo() : base("int")
        {
        }

        public string ParentTable { get; set; }

        [XmlIgnore]
        public TableInfo ParentTableInfo { get; set; }

        protected override void OnSet(MultipleFieldDefinition definition)
        {
            base.OnSet(definition);
            ParentTable = definition.ParentTable;
        }

        public override void SetRef(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo, TableInfo table)
        {
            ParentTableInfo = databaseInfo.Tables.GetByName(ParentTable);
        }

        public override void SetAdd(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo, TableInfo table)
        {
            if (ParentTableInfo != null)
            {
                MultipleFieldInfo child = new MultipleFieldInfo
                {
                    Name = table.Plural,
                    ParentTable = Name,
                    ParentTableInfo = table
                };

                ParentTableInfo.Fields.Add(child);
            }

        }

        public override ControlInfo CreateControl()
        {
            return new MultipleControlInfo();
        }
    }
}