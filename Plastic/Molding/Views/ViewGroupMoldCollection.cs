using Plastic.Infos.Views;

namespace Plastic.Molding.Views
{
    public abstract class ViewGroupMoldCollection<T> : MoldCollection<T, ViewGroupInfo>
        where T : IViewGroupMold
    { }
}