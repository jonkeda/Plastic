using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public class StringFieldInfo : EfFieldInfo<StringFieldDefinition, string>
    {
        public StringFieldInfo() : base("string")
        { }

        public int Length { get; set; } = -1;
        public int MinimumLength { get; set; } = -1;
        public string LengthErrorMessage { get; set; }

        protected override void OnSet(StringFieldDefinition definition)
        {
            base.OnSet(definition);
            Length = definition.Length;
            MinimumLength = definition.MinimumLength;
            LengthErrorMessage = definition.LengthErrorMessage;
        }

        public override ControlInfo CreateControl()
        {
            return new StringControlInfo();
        }
    }
}