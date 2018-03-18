using System;
using Plastic.Definitions.Data;
using Plastic.Definitions.Views;
using Plastic.Infos.Data;
using Plastic.Infos.Views;
using Plastic.Molding.Cs.Data.EntityFramework;

namespace Plastic.PatternChecks.Data
{
    public class DateTimeFieldCheck : FieldPatternCheck<DateTime, 
        DateTimeFieldDefinition, DateTimeFieldInfo, 
        EfDateTimeFieldMold, 
        DateTimeControlDefinition, DateTimeControlInfo>
    {
    }
}