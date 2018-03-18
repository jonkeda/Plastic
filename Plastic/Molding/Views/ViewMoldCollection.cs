using Plastic.Infos.Views;

namespace Plastic.Molding.Views
{
    public abstract class ViewMoldCollection<T> : MoldCollection<T, IViewInfo>
        where T : IViewMold
    { }
}