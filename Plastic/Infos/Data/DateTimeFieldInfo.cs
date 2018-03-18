using System;
using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public class DateTimeFieldInfo : EfFieldInfo<DateTimeFieldDefinition, DateTime>
    {
        public DateTimeFieldInfo() : base("DateTime")
        { }

        public DateTimeType Type { get; set; }

        protected override void OnSet(DateTimeFieldDefinition definition)
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