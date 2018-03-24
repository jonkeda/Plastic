using Plastic.Infos.Entities;
using Plastic.Molding.Entities;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public interface ITsmAttributeMold : IAttributeMold
    {
        void CreateDataclass(IAttributeInfo field, CodeWriter cw);

    }

    public abstract class TsmAttributeMold<T> : TsMold<T>, ITsmAttributeMold
        where T : class, IAttributeInfo
    {
        protected virtual void DoCreateDataclass(T field, CodeWriter cw)
        {
            DoWriteAttributes(field, cw);

            cw.WriteLine($@"private _{field.Name}: {GetTypeName(field)} = undefined;");
            cw.WriteLine($@"get {field.Name}():{GetTypeName(field)} {{ return this._{field.Name}; }}");
            cw.WriteLine($@"set {field.Name}(value: {GetTypeName(field)}) {{ this._{field.Name} = value; }}");
        }

        protected virtual string GetTypeName(T field)
        {
            return TsUtility.GetTypeName("", "");
        }

        protected virtual void DoWriteAttributes(T field, CodeWriter cw)
        {
            cw.WriteLine($@"@JsonProperty(""{field.JsonName}"", {GetTypeName(field)})");
        }

        public void CreateDataclass(IAttributeInfo field, CodeWriter cw)
        {
            DoCreateDataclass(field as T, cw);
        }
    }

    public class TsmCalculatedAttributeMold : TsmAttributeMold<CalculatedAttributeInfo>
    {

    }

    public class TsmBoolAttributeMold : TsmAttributeMold<BoolAttributeInfo>
    {

        protected override string GetTypeName(BoolAttributeInfo field)
        {
            return TsTypes.Boolean;
        }

    }

    public class TsmDateTimTsmieldMold : TsmAttributeMold<DateTimeAttributeInfo>
    {
        protected override string GetTypeName(DateTimeAttributeInfo field)
        {
            return TsTypes.Date;
        }
    }

    public class TsmNumberModelAttributeMold<T> : TsmAttributeMold<T>
        where T : class, INumberAttributeInfo
    {
        protected override string GetTypeName(T field)
        {
            return TsTypes.Number;
        }
    }


    public class TsmDecimalAttributeMold : TsmNumberModelAttributeMold<DecimalAttributeInfo>
    {
    }

    public class TsmIntAttributeMold : TsmNumberModelAttributeMold<IntAttributeInfo>
    {
    }

    public class TsmMultipleFieldMold : TsmAttributeMold<MultipleAttributeInfo>
    {

        protected override string GetTypeName(MultipleAttributeInfo field)
        {
            return TsUtility.GetTypeName(field.ParentEntityInfo?.Name, "");
        }
    }

    public class TsmEnumerationAttributeMold : TsmAttributeMold<EnumerationAttributeInfo>
    {
        protected override string GetTypeName(EnumerationAttributeInfo field)
        {
            return "enumerations." + field.EnumerationInfo?.Name;
        }
    }

    public class TsmParentAttributeMold : TsmAttributeMold<ParentAttributeInfo>
    {
        protected override string GetTypeName(ParentAttributeInfo field)
        {
            return TsUtility.GetTypeName(field.ParentEntityInfo?.Name, "");
        }
    }

    public class TsmChildAttributeMold : TsmAttributeMold<ChildAttributeInfo>
    {
        protected override string GetTypeName(ChildAttributeInfo field)
        {
            return TsUtility.GetTypeName(field.ChildEntityInfo?.Name, "") + "[]";
        }

        protected override void DoWriteAttributes(ChildAttributeInfo field, CodeWriter cw)
        {
            cw.WriteLine($@"@JsonProperty(""{field.JsonName}"", [{TsUtility.GetTypeName(field.ChildEntityInfo?.Name, "")}])");
        }
    }

    public class TsmStringAttributeMold : TsmAttributeMold<StringAttributeInfo>
    {
        protected override string GetTypeName(StringAttributeInfo field)
        {
            return TsTypes.String;
        }
    }
}