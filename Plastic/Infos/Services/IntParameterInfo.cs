using Plastic.Definitions.Services;
using Plastic.Infos.Views;

namespace Plastic.Infos.Services
{
    public class IntParameterInfo : NumberParameterInfo<IntParameterDefinition, int>
    {
        public IntParameterInfo() : base("int")
        { }

        public override ControlInfo CreateControl()
        {
            return new IntControlInfo();
        }
    }
}