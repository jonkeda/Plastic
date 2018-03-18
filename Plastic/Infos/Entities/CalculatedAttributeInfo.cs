using Plastic.Definitions.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public class CalculatedAttributeInfo : AttributeInfo<CalculatedAttributeDefinition, string>
    {
        public CalculatedAttributeInfo() : base("")
        {
        }

        public override ControlInfo CreateControl()
        {
            return new CalculatedControlInfo();
        }
    }
}