using System;
using Plastic.Definitions.Data;
using Plastic.Definitions.Entities;
using Plastic.Infos.Views;

namespace Plastic.Infos.Entities
{
    public class DateTimeAttributeInfo : AttributeInfo<DateTimeAttributeDefinition, DateTime>
    {
        public DateTimeAttributeInfo() : base("DateTime")
        { }

        public DateTimeType Type { get; set; }

        protected override void OnSet(DateTimeAttributeDefinition definition)
        {
            base.OnSet(definition);
            Type = definition.Type;
        }

        public override ControlInfo CreateControl()
        {
            return new DateTimeControlInfo();
        }
    }
}