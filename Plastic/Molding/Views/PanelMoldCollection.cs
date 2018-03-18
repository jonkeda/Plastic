using Plastic.Infos.Views;

namespace Plastic.Molding.Views
{
    public abstract class PanelMoldCollection<T> : MoldCollection<T, PanelInfo>
        where T : IPanelMold
    { }
}