using Plastic.Infos;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public class TsmDossier : Dossier
    {
        public TsmApplicationMold ApplicationMold { get; }

        public TsmDossier(TsmApplicationMold mold, ApplicationInfo info) 
            : base(info)
        {
            ApplicationMold = mold;
        }
    }
}