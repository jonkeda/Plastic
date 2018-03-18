using Plastic.Infos;

namespace Plastic.Molding
{
    public abstract class Factory
    {
        private IApplicationMold Mold { get; }

        protected Factory(IApplicationMold mold)
        {
            Mold = mold;
        }

        public void Manufacture(Shipment shipment, ApplicationInfo applicationInfo)
        {
            Dossier dossier = CreateDossier(applicationInfo);

            Mold.Manufacture(dossier);

            foreach (Pallet pallet in dossier.Pallets)
            {
                shipment.Pallets.Add(pallet);
            }
        }

        protected abstract Dossier CreateDossier(ApplicationInfo info);
    }
}