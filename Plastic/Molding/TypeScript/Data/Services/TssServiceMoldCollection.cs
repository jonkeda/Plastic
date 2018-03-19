using Plastic.Molding.Services;

namespace Plastic.Molding.TypeScript.Data.Services
{
    public class TssServiceMoldCollection : ServiceInterfaceMoldCollection<TssServiceMold>
    {
        protected override void AddTypes()
        {
            AddType<TssServiceMold>();
        }
    }
}