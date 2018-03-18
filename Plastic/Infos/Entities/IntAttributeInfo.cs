using Plastic.Definitions.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public class IntAttributeInfo : NumberAttributeInfo<IntAttributeDefinition, int>
    {
        public IntAttributeInfo() : base("int")
        { }

        public override ControlInfo CreateControl()
        {
            return new IntControlInfo();
        }
    }
}