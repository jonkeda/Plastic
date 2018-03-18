                                                                                                                                                                                                                                                                                                                                                                            using Plastic.Infos.Views;
                                                                                                                                                                                                                                                                                                                                                                            using Plastic.Molding.Views;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public interface IMvcControlMold : IControlMold
    {
        void CreateDataclass(IControlInfo control, CodeWriter cw);
        void Manufacture(ControlInfo controlInfo, Dossier dossier);
    }

    public abstract class MvcControlMold<T> : MvcMold<T>, IMvcControlMold
        where T : class, IControlInfo
    {
        protected virtual void DoCreateDataclass(T control, CodeWriter cw)
        {
            DoWriteAttributes(control, cw);
            //cw.WriteLine($"public {Control.TypeName} {Control.Name} {{ get; set; }}");
        }

        protected virtual void DoWriteAttributes(T control, CodeWriter cw)
        {
            //if (Control.Key > 0)
            //{
            //    cw.WriteLine("[Key]");
            //}
            //if (Control.Required)
            //{
            //    cw.WriteLine("[Required]");
            //}
            //if (Control.Name != Control.DisplayName)
            //{
            //    cw.WriteLine($@"[Display(Name = ""{Control.DisplayName}"")]");
            //}
            //if (Control.Name != Control.ColumnName)
            //{
            //    cw.WriteLine($@"[Column(""{Control.ColumnName}"")]");
            //}
        }

        public void CreateDataclass(IControlInfo control, CodeWriter cw)
        {
            DoCreateDataclass(control as T, cw);
        }

        public void Manufacture(ControlInfo controlInfo, Dossier dossier)
        {
            
        }
    }

    public class MvcCalculatedControlMold : MvcControlMold<CalculatedControlInfo>
    {
        protected override void DoCreateDataclass(CalculatedControlInfo control, CodeWriter cw)
        {
        }
    }

    public class MvcBoolControlMold : MvcControlMold<BoolControlInfo>
    {
    }

    public class MvcDateTimeControlMold : MvcControlMold<DateTimeControlInfo>
    {
        protected override void DoWriteAttributes(DateTimeControlInfo control, CodeWriter cw)
        {
            //base.DoWriteAttributes(Control, cw);
            //if (Control.Type == DateTimeType.Date)
            //{
            //    cw.WriteLine("[DataType(DataType.Date)]");
            //}
            //else if (Control.Type == DateTimeType.Duration)
            //{
            //    cw.WriteLine("[DataType(DataType.Duration)]");
            //}
            //else if (Control.Type == DateTimeType.Time)
            //{
            //    cw.WriteLine("[DataType(DataType.Time)]");
            //}
        }
    }

    public class MvcNumberModelControlMold<T> : MvcControlMold<T>
        where T : class, INumberControlInfo
    {
        protected override void DoWriteAttributes(T control, CodeWriter cw)
        {
            base.DoWriteAttributes(control, cw);
            //if (Control.Type == NumberType.Currency)
            //{
            //    cw.WriteLine("[DataType(DataType.Currency)]");
            //}
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


    public class MvcDecimalControlMold : MvcNumberModelControlMold<DecimalControlInfo>
    {
        protected override void DoWriteAttributes(DecimalControlInfo control, CodeWriter cw)
        {
            base.DoWriteAttributes(control, cw);
            //WriteRange((double?)Control.Minimum, (double?)Control.Maximum, cw);
        }
    }

    public class MvcIntControlMold : MvcNumberModelControlMold<IntControlInfo>
    {
        protected override void DoWriteAttributes(IntControlInfo control, CodeWriter cw)
        {
            base.DoWriteAttributes(control, cw);
            //WriteRange((double?)Control.Minimum, (double?)Control.Maximum, cw);
        }
    }

    public class MvcMultipleControlMold : MvcControlMold<MultipleControlInfo>
    {
        protected override void DoCreateDataclass(MultipleControlInfo control, CodeWriter cw)
        {
            //cw.WriteLine($@"public virtual ICollection<{Control.ParentTableInfo?.Name}> {Control.Name} {{ get; set; }}");
        }
    }

    public class MvcEnumerationControlMold : MvcControlMold<EnumerationControlInfo>
    {
        protected override void DoCreateDataclass(EnumerationControlInfo control, CodeWriter cw)
        {
            //if (!string.IsNullOrEmpty(Control.EmptyText))
            //{
            //    cw.WriteLine($@"[DisplayFormat(NullDisplayText = ""{Control.EmptyText}"")]");
            //}
            //cw.WriteLine($"public {Control.EnumerationInfo?.Name}{(Control.Required ? "" : "?")} {Control.Name} {{ get; set; }}");
        }
    }

    public class MvcParentControlMold : MvcControlMold<ParentControlInfo>
    {
        protected override void DoCreateDataclass(ParentControlInfo control, CodeWriter cw)
        {
            //IControlInfo key = Control.ParentTableInfo?.Key;
            //if (key != null)
            //{
            //    cw.WriteLine($"public {key.TypeName}{(Control.Required ? "" : "?")} {Control.Name}ID {{ get; set; }}");
            //}

            //cw.WriteLine($@"public virtual {Control.ParentTableInfo?.Name} {Control.Name} {{ get; set; }}");

        }
    }

    public class MvcChildControlMold : MvcControlMold<ChildControlInfo>
    {
        protected override void DoCreateDataclass(ChildControlInfo control, CodeWriter cw)
        {
            //cw.WriteLine($@"public virtual ICollection<{Control.ChildTableInfo?.Name}> {Control.Name} {{ get; set; }}");
        }
    }

    public class MvcStringControlMold : MvcControlMold<StringControlInfo>
    {
        protected override void DoWriteAttributes(StringControlInfo control, CodeWriter cw)
        {
            base.DoWriteAttributes(control, cw);
            //if (Control.Length > 0)
            //{
            //    if (Control.MinimumLength > 0)
            //    {
            //        cw.WriteLine($"[StringLength({Control.Length}, MinimumLength = {Control.MinimumLength})]");
            //    }
            //    else
            //    {
            //        cw.WriteLine($"[StringLength({Control.Length})]");
            //    }
            //}
        }
    }
}