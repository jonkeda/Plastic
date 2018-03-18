using Plastic.Molding.Entities;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public class TsmModelMoldCollection : ModelMoldCollection<TsmModelMold>
    {
        protected override void AddTypes()
        {
            AddType<TsmModelMold>();
        }
    }
}