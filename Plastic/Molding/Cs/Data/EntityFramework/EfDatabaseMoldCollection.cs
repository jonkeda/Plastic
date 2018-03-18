using Plastic.Molding.Data;

namespace Plastic.Molding.Cs.Data.EntityFramework
{
    public class EfDatabaseMoldCollection : DatabaseMoldCollection<EfDatabaseMold>
    {
        protected override void AddTypes()
        {
            AddType<EfDatabaseMold>();
        }
    }
}