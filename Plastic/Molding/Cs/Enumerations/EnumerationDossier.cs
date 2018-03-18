using Plastic.Infos;

namespace Plastic.Molding.Cs.Enumerations
{
    public class EnumerationDossier : Dossier
    {
        public ApplicationMold ApplicationMold { get; }

        public EnumerationDossier(ApplicationMold mold, ApplicationInfo info) 
            : base(info)
        {
            ApplicationMold = mold;
        }
    }
}