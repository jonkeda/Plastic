using Plastic.Infos;

namespace Plastic.Molding
{
    public abstract class Dossier
    {
        protected Dossier(ApplicationInfo info)
        {
            Info = info;
        }

        public ApplicationInfo Info { get; }

        public PalletCollection Pallets { get; } = new PalletCollection();

        public ErrorCollection Errors { get; } = new ErrorCollection();

        public void AddError(string message, IInfo fieldInfo)
        {
            Errors.Add(new Error() { Info = fieldInfo, Message = message });
        }
    }
}