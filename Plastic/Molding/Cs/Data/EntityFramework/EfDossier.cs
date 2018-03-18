using Plastic.Infos;

namespace Plastic.Molding.Cs.Data.EntityFramework
{
    public class EfDossier : Dossier
    {
        public EfApplicationMold ApplicationMold { get; }

        public EfDossier(EfApplicationMold mold, ApplicationInfo info) 
            : base(info)
        {
            ApplicationMold = mold;
        }
    }
}