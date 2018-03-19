using Plastic.Definitions.Services;
using Plastic.Infos.Views;

namespace Plastic.Infos.Services
{
    public class DecimalParameterInfo : NumberParameterInfo<DecimalParameterDefinition, decimal>
    {
        public DecimalParameterInfo() : base("decimal")
        { }

        public override ControlInfo CreateControl()
        {
            return new DecimalControlInfo();
        }
    }
}