using Plastic.Infos;
using Plastic.Infos.Entities;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public class TsmApplicationMold : TsmMold<ApplicationInfo>, IApplicationMold
    {
        public TsmModelMoldCollection Models { get; } = new TsmModelMoldCollection();

        public void Manufacture(Dossier dossier)
        {
            foreach (ModelInfo info in dossier.Info.Models)
            {
                TsmModelMold mold = Models.Create(info);
                mold.Manufacture(dossier as TsmDossier);
            }
            TsmEnumerationMold enumerationMold = new TsmEnumerationMold();
            enumerationMold.Manufacture(dossier as TsmDossier);
        }
    }
}