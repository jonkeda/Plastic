using Plastic.Definitions.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public class DecimalAttributeInfo : NumberAttributeInfo<DecimalAttributeDefinition, decimal>
    {
        public DecimalAttributeInfo() : base("decimal")
        { }

        public override ControlInfo CreateControl()
        {
            return new DecimalControlInfo();
        }
    }
}