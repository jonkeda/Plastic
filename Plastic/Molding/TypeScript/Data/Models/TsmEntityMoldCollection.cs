using Plastic.Molding.Entities;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public class TsmEntityMoldCollection : EntityMoldCollection<TsmEntityMold>
    {
        protected override void AddTypes()
        {
            AddType<TsmEntityMold>();
        }
    }
}