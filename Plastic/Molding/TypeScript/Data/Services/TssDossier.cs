using Plastic.Infos;

namespace Plastic.Molding.TypeScript.Data.Services
{
    public class TssDossier : Dossier
    {
        public TssApplicationMold ApplicationMold { get; }

        public TssDossier(TssApplicationMold mold, ApplicationInfo info) 
            : base(info)
        {
            ApplicationMold = mold;
        }
    }
}