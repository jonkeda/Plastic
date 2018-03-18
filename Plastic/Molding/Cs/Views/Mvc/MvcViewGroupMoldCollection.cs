using Plastic.Molding.Views;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public class MvcViewGroupMoldCollection : ViewGroupMoldCollection<MvcViewGroupMold>
    {
        protected override void AddTypes()
        {
            AddType<MvcViewGroupMold>();
        }
    }
}