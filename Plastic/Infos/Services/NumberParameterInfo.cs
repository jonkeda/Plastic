using Plastic.Definitions.Data;
using Plastic.Definitions.Services;

namespace Plastic.Infos.Services
{
    public abstract class NumberParameterInfo<TD, T> : ParameterInfo<TD, T>, INumberParameterInfo
        where TD : NumberParameterDefinition<T>
        where T : struct
    {
        protected NumberParameterInfo(string typeName) : base(typeName)
        { }

        protected override void OnSet(TD definition)
        {
            base.OnSet(definition);
        }

        public NumberType Type { get; set; }
        public T? Minimum { get; set; }
        public T? Maximum { get; set; }
    }
}