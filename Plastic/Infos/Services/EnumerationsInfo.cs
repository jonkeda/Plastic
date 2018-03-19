using Plastic.Definitions.Enumerations;

namespace Plastic.Infos.Services
{
    public class EnumerationInfoCollection : InfoCollection<EnumerationInfo, EnumerationDefinition, ApplicationInfo>
    {
        public EnumerationInfoCollection(ApplicationInfo parent) : base(parent)
        {
        }
    }

    public class EnumerationInfo : Info<EnumerationDefinition, ApplicationInfo>
    {
        public EnumerationInfo()
        {
            Values = new ValueInfoCollection(this);
        }

        public ValueInfoCollection Values { get; }

        protected override void OnSet(EnumerationDefinition definition)
        {
            Values.Set(definition.Values);
        }
    }


    public class ValueInfoCollection : InfoCollection<ValueInfo, ValueDefinition, EnumerationInfo>
    {
        public ValueInfoCollection(EnumerationInfo parent) : base(parent)
        {
        }
    }

    public class ValueInfo : Info<ValueDefinition, EnumerationInfo>
    {
    }
}
