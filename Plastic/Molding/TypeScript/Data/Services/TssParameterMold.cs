using Plastic.Infos.Services;
using Plastic.Molding.Services;

namespace Plastic.Molding.TypeScript.Data.Services
{
    public interface ITssParameterMold : IParameterMold
    {
        void DoCreateParameter(IParameterInfo field, CodeWriter cw);

    }

    public abstract class TssParameterMold<T> : TsMold<T>, ITssParameterMold
        where T : class, IParameterInfo
    {
        protected virtual void DoCreateParameter(T field, CodeWriter cw)
        {
            DoWriteParameters(field, cw);

            cw.Write($@"{field.Name}: {GetTypeName(field)}");
        }

        protected virtual string GetTypeName(T field)
        {
            return TsUtility.GetTypeName("", "");
        }

        protected virtual void DoWriteParameters(T field, CodeWriter cw)
        {
            // cw.WriteLine($@"@JsonProperty(""{field.Name}"", {GetTypeName()})");
        }

        public void DoCreateParameter(IParameterInfo field, CodeWriter cw)
        {
            DoCreateParameter(field as T, cw);
        }


    }

    public class TssCalculatedParameterMold : TssParameterMold<CalculatedParameterInfo>
    {

    }

    public class TssBoolParameterMold : TssParameterMold<BoolParameterInfo>
    {

        protected override string GetTypeName(BoolParameterInfo field)
        {
            return TsTypes.Boolean;
        }

    }

    public class TssDateTimTssieldMold : TssParameterMold<DateTimeParameterInfo>
    {

    }

    public class TssNumberServiceInterfacesParameterMold<T> : TssParameterMold<T>
        where T : class, INumberParameterInfo
    {
    }


    public class TssDecimalParameterMold : TssNumberServiceInterfacesParameterMold<DecimalParameterInfo>
    {
    }

    public class TssIntParameterMold : TssNumberServiceInterfacesParameterMold<IntParameterInfo>
    {
    }

    public class TssMultipleFieldMold : TssParameterMold<MultipleParameterInfo>
    {

        protected override string GetTypeName(MultipleParameterInfo field)
        {
            return TsUtility.GetTypeName(field.ParentServiceInfo?.Name, "models");
        }
    }

    public class TssEnumerationParameterMold : TssParameterMold<EnumerationParameterInfo>
    {
        protected override string GetTypeName(EnumerationParameterInfo field)
        {
            return "enumerations." + field.EnumerationInfo?.Name;
        }
    }

    public class TssEntityParameterMold : TssParameterMold<EntityParameterInfo>
    {
        protected override string GetTypeName(EntityParameterInfo field)
        {
            return TsUtility.GetTypeName(field.EntityInfo?.Name, "models");
        }
    }

    public class TssStringParameterMold : TssParameterMold<StringParameterInfo>
    {
        protected override string GetTypeName(StringParameterInfo field)
        {
            return TsTypes.String;
        }
    }
}