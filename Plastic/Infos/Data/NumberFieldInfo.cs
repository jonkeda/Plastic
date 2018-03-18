using Plastic.Definitions.Data;

namespace Plastic.Infos.Data
{
    public abstract class NumberFieldInfo<TD, T> : EfFieldInfo<TD, T>, INumberFieldInfo
        where TD : NumberFieldDefinition<T>
        where T : struct
    {
        protected NumberFieldInfo(string typeName) : base(typeName)
        { }

        protected override void OnSet(TD definition)
        {
            base.OnSet(definition);
            Minimum = definition.Minimum;
            Maximum = definition.Maximum;
            Type = definition.Type;
        }

        public NumberType Type { get; set; }
        public T? Minimum { get; set; }
        public T? Maximum { get; set; }
    }
}