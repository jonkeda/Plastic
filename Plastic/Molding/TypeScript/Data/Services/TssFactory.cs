using Plastic.Infos;

namespace Plastic.Molding.TypeScript.Data.Services
{
    public class TssFactory : Factory
    {
        public TssFactory() 
            : base(new TssApplicationMold())
        { }

        protected override Dossier CreateDossier(ApplicationInfo info)
        {
            return new TssDossier(new TssApplicationMold(), info);
        }
    }
}