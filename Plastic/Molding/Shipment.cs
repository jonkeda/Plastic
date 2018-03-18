using System.Collections.ObjectModel;
using Plastic.Infos;

namespace Plastic.Molding
{
    public class ErrorCollection : Collection<Error>
    { }

    public class Error
    {
        public string Message { get; set; }

        public IInfo Info { get; set; }

        public IMold Mold { get; set; }
    }

    public class Shipment
    {
        public Shipment()
        {
        }

        public Shipment(PalletCollection pallets)
        {
            Pallets = pallets;
        }

        public PalletCollection Pallets { get; } = new PalletCollection();

        public void Save(string path)
        {
            foreach (Pallet pallet in Pallets)
            {
                pallet.Save(path);
            }
        }
    }
}