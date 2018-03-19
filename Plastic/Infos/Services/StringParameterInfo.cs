using Plastic.Definitions.Services;
using Plastic.Infos.Views;

namespace Plastic.Infos.Services
{
    public class StringParameterInfo : ParameterInfo<StringParameterDefinition, string>
    {
        public StringParameterInfo() : base("string")
        { }

        public int Length { get; set; } = -1;
        public int MinimumLength { get; set; } = -1;
        public string LengthErrorMessage { get; set; }

        public override ControlInfo CreateControl()
        {
            return new StringControlInfo();
        }
    }
}