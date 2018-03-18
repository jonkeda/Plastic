using Plastic.Infos;

namespace Plastic.Molding.Cs.Enumerations
{
    public class EnumerationFactory : Factory
    {
        public EnumerationFactory() 
            : base(new ApplicationMold())
        {
        }

        protected override Dossier CreateDossier(ApplicationInfo info)
        {
            return new EnumerationDossier(new ApplicationMold(), info);
        }
    }
}