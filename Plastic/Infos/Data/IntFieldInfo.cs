using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public class IntFieldInfo : NumberFieldInfo<IntFieldDefinition, int>
    {
        public IntFieldInfo() : base("int")
        { }

        public override ControlInfo CreateControl()
        {
            return new IntControlInfo();
        }
    }
}