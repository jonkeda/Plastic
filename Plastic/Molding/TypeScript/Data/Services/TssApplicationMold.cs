using Plastic.Infos;
using Plastic.Infos.Services;

namespace Plastic.Molding.TypeScript.Data.Services
{
    public class TssApplicationMold : TsMold<ApplicationInfo>, IApplicationMold
    {
        public TssServiceMoldCollection Services { get; } = new TssServiceMoldCollection();

        public void Manufacture(Dossier dossier)
        {
            Pallet pallet = new Pallet();

            CodeWriter cw = new CodeWriter();

            cw.WriteLine($@"import * as enumerations from  ""../Models/Enumerations""");
            cw.WriteLine($@"import * as models from  ""../Models/Models""");

            foreach (ServiceInfo info in dossier.Info.Services)
            {
                TssServiceMold mold = Services.Create(info);
                mold.CreateInterfaces(cw, dossier, info);
            }

            pallet.AddProduct("TssServiceInterface", "Services", $@"Interfaces.ts", cw);

            dossier.Pallets.Add(pallet);
        }
    }
}