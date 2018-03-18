using Plastic.Definitions.Entities;

namespace Plastic.Infos.Entities
{
    public class AttributeInfoCollection : InfosCollection<IAttributeInfo, AttributeDefinition, EntityInfo>
    {
        public AttributeInfoCollection(EntityInfo parent) : base(parent)
        {
        }

        protected override void AddTypes()
        {
            AddType<IntAttributeInfo>();
            AddType<DateTimeAttributeInfo>();
            AddType<CalculatedAttributeInfo>();
            AddType<DecimalAttributeInfo>();
            AddType<MultipleAttributeInfo>();
            AddType<ChildAttributeInfo>();
            AddType<EnumerationAttributeInfo>();
            AddType<ParentAttributeInfo>();
            AddType<StringAttributeInfo>();
        }
    }
}