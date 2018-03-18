using Plastic.Definitions;
using Plastic.Infos;
using Plastic.Molding.Cs.Data.EntityFramework;

namespace Plastic.PatternChecks
{
    public class PatternCheck<TDefinition, TInfo, TEf>
        where TDefinition : Definition
        where TInfo : Info<TDefinition>
        where TEf : EfMold<TInfo>
    {
        public TDefinition Definition;
        public TInfo Info;
        public TEf EntityFramework;
    }
}
