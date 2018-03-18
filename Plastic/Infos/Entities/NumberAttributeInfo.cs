using Plastic.Definitions.Data;
using Plastic.Definitions.Entities;

namespace Plastic.Infos.Entities
{
    public abstract class NumberAttributeInfo<TD, T> : AttributeInfo<TD, T>, INumberAttributeInfo
        where TD : NumberAttributeDefinition<T>
        where T : struct
    {
        protected NumberAttributeInfo(string typeName) : base(typeName)
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