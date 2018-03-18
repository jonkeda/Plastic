using Plastic.Molding.Views;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public class MvcPanelMoldCollection : PanelMoldCollection<MvcPanelMold>
    {
        protected override void AddTypes()
        {
            AddType<MvcPanelMold>();
        }
    }
}