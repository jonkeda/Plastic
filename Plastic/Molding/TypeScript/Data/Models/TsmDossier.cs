using Plastic.Infos;
using Plastic.Molding.TypeScript.Data.Models;

namespace Plastic.Molding.TypeScript
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