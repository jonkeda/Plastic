using Plastic.Definitions.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public class StringAttributeInfo : AttributeInfo<StringAttributeDefinition, string>
    {
        public StringAttributeInfo() : base("string")
        { }

        public int Length { get; set; } = -1;
        public int MinimumLength { get; set; } = -1;
        public string LengthErrorMessage { get; set; }

        protected override void OnSet(StringAttributeDefinition definition)
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