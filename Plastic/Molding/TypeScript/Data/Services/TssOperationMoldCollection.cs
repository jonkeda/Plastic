using Plastic.Molding.Services;

namespace Plastic.Molding.TypeScript.Data.Services
{
    public class TssOperationMoldCollection : ServiceMoldCollection<TssOperationMold>
    {
        protected override void AddTypes()
        {
            AddType<TssOperationMold>();
        }
    }
}