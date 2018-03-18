using Plastic.Infos;
using Plastic.Infos.Views;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public class MvcApplicationMold : MvcMold<ApplicationInfo>, IApplicationMold
    {
        public MvcViewGroupMoldCollection ViewGroups { get; } = new MvcViewGroupMoldCollection();

        public void Manufacture(Dossier dossier)
        {
            //MvcDossier 
            //foreach (ViewGroupInfo info in dossier.Info.UserInterfaces.ViewGroups)
            //{
            //    EfViewGroupMold mold = ViewGroups.Create(info);
            //    mold.Manufacture(dossier as MvcDossier);
            //}

            foreach (UserInterfaceInfo info in dossier.Info.UserInterfaces)
            {
                Manufacture(info, dossier);
            }
        }

        private void Manufacture(UserInterfaceInfo parent, Dossier dossier)
        {
            Pallet pallet = new Pallet();

            MvcViewGroupMold mold = new MvcViewGroupMold();
            foreach (ViewGroupInfo group in parent.Groups)
            {
                mold.Manufacture(group, dossier, pallet);

            }

            dossier.Pallets.Add(pallet);
        }

    }
}