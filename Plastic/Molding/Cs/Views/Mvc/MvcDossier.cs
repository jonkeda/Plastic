using Plastic.Infos;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public class MvcDossier : Dossier
    {
        public MvcApplicationMold ApplicationMold { get; }

        public MvcDossier(MvcApplicationMold mold, ApplicationInfo info) 
            : base(info)
        {
            ApplicationMold = mold;
        }
    }
}