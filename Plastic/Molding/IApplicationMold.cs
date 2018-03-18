using Plastic.Infos;

namespace Plastic.Molding
{
    public interface IApplicationMold : IMold<ApplicationInfo>
    {
        void Manufacture(Dossier dossier);
    }
}