using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public class BoolFieldInfo : EfFieldInfo<BoolFieldDefinition, bool>
    {
        public BoolFieldInfo() : base("bool")
        { }

        public override ControlInfo CreateControl()
        {
            return new BoolControlInfo(); 
        }
    }
}