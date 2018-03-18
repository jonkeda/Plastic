using Plastic.Definitions.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public class BoolAttributeInfo : AttributeInfo<BoolAttributeDefinition, bool>
    {
        public BoolAttributeInfo() : base("bool")
        { }

        public override ControlInfo CreateControl()
        {
            return new BoolControlInfo(); 
        }
    }
}