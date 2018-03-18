using Plastic.Definitions.Entities;
using Plastic.Infos.Enumerations;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public class EnumerationAttributeInfo : AttributeInfo<EnumerationAttributeDefinition>
    {
        public EnumerationAttributeInfo() : base("")
        { }

        public string EmptyText { get; set; }
        public string EnumerationName { get; set; }
        public EnumerationInfo EnumerationInfo { get; set; }

        protected override void OnSet(EnumerationAttributeDefinition definition)
        {
            base.OnSet(definition);

            EmptyText = definition.EmptyText;

            EnumerationName = definition.EnumerationName;
        }

        public override void SetRef(ApplicationInfo applicationInfo, ModelInfo databaseInfo, EntityInfo table)
        {
            EnumerationInfo = applicationInfo.Enumerations.GetByName(EnumerationName);
        }

        public override ControlInfo CreateControl()
        {
            return new EnumerationControlInfo();
        }
    }
}