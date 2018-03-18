using Plastic.Molding.Views;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public class MvcViewMoldCollection : ViewMoldCollection<IMvcViewMold>
    {
        protected override void AddTypes()
        {
            AddType<MvcEditViewMold>();
            AddType<MvcDeleteViewMold>();
            AddType<MvcDetailViewMold>();
            AddType<MvcIndexViewMold>();
            AddType<MvcCreateViewMold>();
        }
    }
}