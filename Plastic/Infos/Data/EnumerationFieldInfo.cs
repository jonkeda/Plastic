using Plastic.Definitions.Data;
using Plastic.Infos.Services;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public class EnumerationFieldInfo : EfFieldInfo<EnumerationFieldDefinition>
    {
        public EnumerationFieldInfo() : base("")
        { }

        public string EmptyText { get; set; }
        public string EnumerationName { get; set; }
        public EnumerationInfo EnumerationInfo { get; set; }

        protected override void OnSet(EnumerationFieldDefinition definition)
        {
            base.OnSet(definition);

            EmptyText = definition.EmptyText;

            EnumerationName = definition.EnumerationName;
        }

        public override void SetRef(ApplicationInfo applicationInfo, DatabaseInfo databaseInfo, TableInfo table)
        {
            EnumerationInfo = applicationInfo.Enumerations.GetByName(EnumerationName);
        }

        public override ControlInfo CreateControl()
        {
            return new EnumerationControlInfo();
        }
    }
}