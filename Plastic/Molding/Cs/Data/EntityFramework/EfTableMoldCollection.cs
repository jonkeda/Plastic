using Plastic.Molding.Data;

namespace Plastic.Molding.Cs.Data.EntityFramework
{
    public class EfTableMoldCollection : TableMoldCollection<EfTableMold>
    {
        protected override void AddTypes()
        {
            AddType<EfTableMold>();
        }
    }
}