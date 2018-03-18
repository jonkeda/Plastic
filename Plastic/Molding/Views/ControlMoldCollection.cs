using Plastic.Infos.Views;

namespace Plastic.Molding.Views
{
    public abstract class ControlMoldCollection<T> : MoldCollection<T, IControlInfo>
        where T : IControlMold
    { }
}