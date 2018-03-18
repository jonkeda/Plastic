using Plastic.Molding.Views;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public class MvcControlMoldCollection : ControlMoldCollection<IMvcControlMold>
    {
        protected override void AddTypes()
        {
            AddType<MvcCalculatedControlMold>();
            AddType<MvcDecimalControlMold>();
            AddType<MvcIntControlMold>();
            AddType<MvcStringControlMold>();
            AddType<MvcDateTimeControlMold>();
            AddType<MvcParentControlMold>();
            AddType<MvcChildControlMold>();
            AddType<MvcMultipleControlMold>();
            AddType<MvcEnumerationControlMold>();
            AddType<MvcBoolControlMold>();
        }
    }
}