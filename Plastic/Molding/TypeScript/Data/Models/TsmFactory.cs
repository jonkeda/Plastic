using Plastic.Infos;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public class TsmFactory : Factory
    {
        public TsmFactory() 
            : base(new TsmApplicationMold())
        { }

        protected override Dossier CreateDossier(ApplicationInfo info)
        {
            return new TsmDossier(new TsmApplicationMold(), info);
        }
    }
}