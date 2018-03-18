using Plastic.Definitions.Data;
using Plastic.Infos.Data;
using Plastic.Molding.Data;

namespace Plastic.Molding.Cs.Data.EntityFramework
{
    public interface IEfFieldMold : IFieldMold
    {
        void CreateDataclass(IFieldInfo field, CodeWriter cw);
    }

    public abstract class EfFieldMold<T> : EfMold<T>, IEfFieldMold
        where T : class, IFieldInfo
    {
        protected virtual void DoCreateDataclass(T field, CodeWriter cw)
        {
            DoWriteAttributes(field, cw);
            cw.WriteLine($"public {field.TypeName} {field.Name} {{ get; set; }}");
        }

        protected virtual void DoWriteAttributes(T field, CodeWriter cw)
        {
            if (field.Key > 0)
            {
                cw.WriteLine("[Key]");
            }
            if (field.Required)
            {
                cw.WriteLine("[Required]");
            }
            if (field.Name != field.DisplayName)
            {
                cw.WriteLine($@"[Display(Name = ""{field.DisplayName}"")]");
            }
            if (field.Name != field.ColumnName)
            {
                cw.WriteLine($@"[Column(""{field.ColumnName}"")]");
            }
        }

        public void CreateDataclass(IFieldInfo field, CodeWriter cw)
        {
            DoCreateDataclass(field as T, cw);
        }
    }

    public class EfCalculatedFieldMold : EfFieldMold<CalculatedFieldInfo>
    {
        protected override void DoCreateDataclass(CalculatedFieldInfo field, CodeWriter cw)
        {
        }
    }

    public class EfBoolFieldMold : EfFieldMold<BoolFieldInfo>
    {
    }

    public class EfDateTimeFieldMold : EfFieldMold<DateTimeFieldInfo>
    {
        protected override void DoWriteAttributes(DateTimeFieldInfo field, CodeWriter cw)
        {
            base.DoWriteAttributes(field, cw);
            if (field.Type == DateTimeType.Date)
            {
                cw.WriteLine("[DataType(DataType.Date)]");
            }
            else if (field.Type == DateTimeType.Duration)
            {
                cw.WriteLine("[DataType(DataType.Duration)]");
            }
            else if (field.Type == DateTimeType.Time)
            {
                cw.WriteLine("[DataType(DataType.Time)]");
            }
        }
    }

    public class EfNumberModelFieldMold<T> : EfFieldMold<T>
        where T : class, INumberFieldInfo
    {
        protected override void DoWriteAttributes(T field, CodeWriter cw)
        {
            base.DoWriteAttributes(field, cw);
            if (field.Type == NumberType.Currency)
            {
                cw.WriteLine("[DataType(DataType.Currency)]");
            }
        }

        protected void WriteRange(double? minimum, double? maximum, CodeWriter cw)
        {
            if (minimum.HasValue
                && maximum.HasValue)
            {
                cw.WriteLine($"[Range({minimum}, {maximum})]");
            }
        }
    }


    public class EfDecimalFieldMold : EfNumberModelFieldMold<DecimalFieldInfo>
    {
        protected override void DoWriteAttributes(DecimalFieldInfo field, CodeWriter cw)
        {
            base.DoWriteAttributes(field, cw);
            WriteRange((double?)field.Minimum, (double?)field.Maximum, cw);
        }
    }

    public class EfIntFieldMold : EfNumberModelFieldMold<IntFieldInfo>
    {
        protected override void DoWriteAttributes(IntFieldInfo field, CodeWriter cw)
        {
            base.DoWriteAttributes(field, cw);
            WriteRange((double?)field.Minimum, (double?)field.Maximum, cw);
        }
    }

    public class EfMultipleFieldMold : EfFieldMold<MultipleFieldInfo>
    {
        protected override void DoCreateDataclass(MultipleFieldInfo field, CodeWriter cw)
        {
            cw.WriteLine($@"public virtual ICollection<{field.ParentTableInfo?.Name}> {field.Name} {{ get; set; }}");
        }
    }

    public class EfEnumerationFieldMold : EfFieldMold<EnumerationFieldInfo>
    {
        protected override void DoCreateDataclass(EnumerationFieldInfo field, CodeWriter cw)
        {
            if (!string.IsNullOrEmpty(field.EmptyText))
            {
                cw.WriteLine($@"[DisplayFormat(NullDisplayText = ""{field.EmptyText}"")]");
            }
            cw.WriteLine($"public {field.EnumerationInfo?.Name}{(field.Required ? "" : "?")} {field.Name} {{ get; set; }}");
        }
    }

    public class EfParentFieldMold : EfFieldMold<ParentFieldInfo>
    {
        protected override void DoCreateDataclass(ParentFieldInfo field, CodeWriter cw)
        {
            IFieldInfo key = field.ParentTableInfo?.Key;
            if (key != null)
            {
                cw.WriteLine($"public {key.TypeName}{(field.Required ? "" : "?")} {field.Name}ID {{ get; set; }}");
            }

            cw.WriteLine($@"public virtual {field.ParentTableInfo?.Name} {field.Name} {{ get; set; }}");

        }
    }

    public class EfChildFieldMold : EfFieldMold<ChildFieldInfo>
    {
        protected override void DoCreateDataclass(ChildFieldInfo field, CodeWriter cw)
        {
            cw.WriteLine($@"public virtual ICollection<{field.ChildTableInfo?.Name}> {field.Name} {{ get; set; }}");
        }
    }

    public class EfStringFieldMold : EfFieldMold<StringFieldInfo>
    {
        protected override void DoWriteAttributes(StringFieldInfo field, CodeWriter cw)
        {
            base.DoWriteAttributes(field, cw);
            if (field.Length > 0)
            {
                if (field.MinimumLength > 0)
                {
                    cw.WriteLine($"[StringLength({field.Length}, MinimumLength = {field.MinimumLength})]");
                }
                else
                {
                    cw.WriteLine($"[StringLength({field.Length})]");
                }
            }
        }
    }
}