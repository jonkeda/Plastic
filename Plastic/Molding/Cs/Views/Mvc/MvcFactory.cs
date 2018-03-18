using Plastic.Infos;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public class MvcFactory : Factory
    {
        public MvcFactory() 
            : base(new MvcApplicationMold())
        { }

        protected override Dossier CreateDossier(ApplicationInfo info)
        {
            return new MvcDossier(new MvcApplicationMold(), info);
        }
    }
}