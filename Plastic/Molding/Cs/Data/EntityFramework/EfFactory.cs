using Plastic.Infos;

namespace Plastic.Molding.Cs.Data.EntityFramework
{
    public class EfFactory : Factory
    {
        public EfFactory() 
            : base(new EfApplicationMold())
        { }

        protected override Dossier CreateDossier(ApplicationInfo info)
        {
            return new EfDossier(new EfApplicationMold(), info);
        }
    }
}