using Plastic.Definitions.Services;
using Plastic.Infos.Views;

namespace Plastic.Infos.Services
{
    public class CalculatedParameterInfo : ParameterInfo<CalculatedParameterDefinition, string>
    {
        public CalculatedParameterInfo() : base("")
        {
        }

        public override ControlInfo CreateControl()
        {
            return new CalculatedControlInfo();
        }
    }
}