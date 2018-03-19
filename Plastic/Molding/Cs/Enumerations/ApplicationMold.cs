using Plastic.Infos;
using Plastic.Infos.Services;

namespace Plastic.Molding.Cs.Enumerations
{
    public class ApplicationMold : Mold<ApplicationInfo>, IApplicationMold
    {
        public EnumerationMoldCollection Enumerations { get; } = new EnumerationMoldCollection();

        public void Manufacture(Dossier dossier)
        {
            foreach (EnumerationInfo info in dossier.Info.Enumerations)
            {
                EnumerationMold mold = Enumerations.Create(info);
                mold.Manufacture(dossier as EnumerationDossier);
            }
        }
    }
}