using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public class DecimalFieldInfo : NumberFieldInfo<DecimalFieldDefinition, decimal>
    {
        public DecimalFieldInfo() : base("decimal")
        { }

        public override ControlInfo CreateControl()
        {
            return new DecimalControlInfo();
        }
    }
}