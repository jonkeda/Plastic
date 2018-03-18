using Plastic.Definitions.Data;
using Plastic.Definitions.Views;
using Plastic.Infos.Data;
using Plastic.Infos.Views;
using Plastic.Molding.Cs.Data.EntityFramework;

namespace Plastic.PatternChecks.Data
{
    public class IntFieldCheck : FieldPatternCheck<int, 
        IntFieldDefinition, IntFieldInfo, 
        EfIntFieldMold, 
        IntControlDefinition, IntControlInfo>
    {
    }
}