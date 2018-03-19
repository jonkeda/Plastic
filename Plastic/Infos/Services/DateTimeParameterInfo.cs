using System;
using Plastic.Definitions.Data;
using Plastic.Definitions.Services;
using Plastic.Infos.Views;

namespace Plastic.Infos.Services
{
    public class DateTimeParameterInfo : ParameterInfo<DateTimeParameterDefinition, DateTime>
    {
        public DateTimeParameterInfo() : base("DateTime")
        { }

        public DateTimeType Type { get; set; }

        public override ControlInfo CreateControl()
        {
            return new DateTimeControlInfo();
        }
    }
}