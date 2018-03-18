using System.Xml.Serialization;
using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public class ParentFieldInfo : EfFieldInfo<ParentFieldDefinition, string>
    {
        public ParentFieldInfo() : base("int")
        { }

        public string ParentTable { get; set; }
        [XmlIgnore]
        public TableInfo ParentTableInfo { get; set; }

        protected override void OnSet(ParentFieldDefinition definition)
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
                ChildFieldInfo child = new ChildFieldInfo
                {
                    Name = table.Plural,
                    ChildTable = Name,
                    ChildTableInfo = table
                };

                ParentTableInfo.Fields.Add(child);
            }
        }

        public override ControlInfo CreateControl()
        {
            return new ParentControlInfo();
        }
    }
}