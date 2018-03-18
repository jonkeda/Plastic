using Plastic.Definitions.Data;
using Plastic.Definitions.Views;
using Plastic.Infos.Data;
using Plastic.Infos.Views;
using Plastic.Molding.Cs.Data.EntityFramework;

namespace Plastic.PatternChecks
{
    public class FieldPatternCheck<T, 
        TDefinition, TInfo, TEf, 
        TControlDefinition, TControlInfo> 
        : PatternCheck<TDefinition, TInfo, TEf>
        where TDefinition : FieldDefinition<T>
        where TInfo : EfFieldInfo<TDefinition, T> 
        where TEf : EfMold<TInfo>
        where TControlDefinition : ControlDefinition<T>
        where TControlInfo : ControlInfo<T>
    {
        public T Value;
        public TControlDefinition ControlDefinition;
        public TControlInfo ControlInfo;
    }
}