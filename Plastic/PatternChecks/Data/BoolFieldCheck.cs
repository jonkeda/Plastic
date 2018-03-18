using Plastic.Definitions.Data;
using Plastic.Definitions.Views;
using Plastic.Infos.Data;
using Plastic.Infos.Views;
using Plastic.Molding.Cs.Data.EntityFramework;

namespace Plastic.PatternChecks.Data
{
    public class BoolFieldCheck : FieldPatternCheck<bool, 
        BoolFieldDefinition, BoolFieldInfo, 
        EfBoolFieldMold, 
        BoolControlDefinition, BoolControlInfo>
    {
    }
}