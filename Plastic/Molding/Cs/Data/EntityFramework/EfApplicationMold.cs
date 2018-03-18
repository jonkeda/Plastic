using Plastic.Infos;
using Plastic.Infos.Data;

namespace Plastic.Molding.Cs.Data.EntityFramework
{
    public class EfApplicationMold : EfMold<ApplicationInfo>, IApplicationMold
    {
        public EfDatabaseMoldCollection Databases { get; } = new EfDatabaseMoldCollection();

        public void Manufacture(Dossier dossier)
        {
            foreach (DatabaseInfo info in dossier.Info.Databases)
            {
                EfDatabaseMold mold = Databases.Create(info);
                mold.Manufacture(dossier as EfDossier);
            }
        }
    }
}