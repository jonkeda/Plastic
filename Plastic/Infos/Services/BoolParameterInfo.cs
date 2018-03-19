using Plastic.Definitions.Services;
using Plastic.Infos.Views;

namespace Plastic.Infos.Services
{
    public class BoolParameterInfo : ParameterInfo<BoolParameterDefinition, bool>
    {
        public BoolParameterInfo() : base("bool")
        { }

        public override ControlInfo CreateControl()
        {
            return new BoolControlInfo(); 
        }
    }
}