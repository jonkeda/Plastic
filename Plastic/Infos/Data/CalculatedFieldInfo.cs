using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public class CalculatedFieldInfo : EfFieldInfo<CalculatedFieldDefinition, string>
    {
        public CalculatedFieldInfo() : base("")
        {
        }

        public override ControlInfo CreateControl()
        {
            return new CalculatedControlInfo();
        }
    }
}