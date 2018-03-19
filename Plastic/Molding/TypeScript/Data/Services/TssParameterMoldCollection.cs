using Plastic.Molding.Services;

namespace Plastic.Molding.TypeScript.Data.Services
{
    public class TssParameterMoldCollection : ParameterMoldCollection<ITssParameterMold>
    {
        protected override void AddTypes()
        {
            AddType<TssCalculatedParameterMold>();
            AddType<TssDecimalParameterMold>();
            AddType<TssIntParameterMold>();
            AddType<TssStringParameterMold>();
            AddType<TssDateTimTssieldMold>();
            AddType<TssEntityParameterMold>();
            AddType<TssMultipleFieldMold>();
            AddType<TssEnumerationParameterMold>();
            AddType<TssBoolParameterMold>();
        }
    }
}