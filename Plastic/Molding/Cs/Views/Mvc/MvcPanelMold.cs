using Plastic.Infos.Views;
using Plastic.Molding.Views;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public class MvcPanelMold : MvcMold<PanelInfo>, IPanelMold
    {
        public MvcControlMoldCollection Controls { get; } = new MvcControlMoldCollection();

        public void Manufacture(PanelInfo info, Dossier dossier)
        {
            foreach (ControlInfo controlInfo in info.Controls)
            {
                IMvcControlMold control = Controls.Create(controlInfo);

                control.Manufacture(controlInfo, dossier);
            }
        }

    }
}