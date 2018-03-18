using Plastic.Infos.Views;
using Plastic.Molding.Views;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public class MvcViewGroupMold : MvcMold<ViewGroupInfo>, IViewGroupMold
    {
        public MvcViewMoldCollection Views { get; } = new MvcViewMoldCollection();

        public void Manufacture(ViewGroupInfo info, Dossier dossier, Pallet pallet)
        {
            CreateController(info, dossier, pallet);

            CreateHtmlControllers(info, dossier, pallet);
        }

        private void CreateHtmlControllers(ViewGroupInfo viewGroup, Dossier dossier, Pallet pallet)
        {
            foreach (IViewInfo view in viewGroup.Views)
            {
                IMvcViewMold viewMold = Views.Create(view);
                HtmlCodeWriter cw = new HtmlCodeWriter();
                viewMold.CreateHtmlView(cw, view);

                pallet.AddProduct("MvcView", $@"Views\{viewGroup.Name}", $@"{view.Name}.cshtml", cw);
            }
        }

        private void CreateController(ViewGroupInfo viewGroup, Dossier dossier, Pallet pallet)
        {
            CodeWriter cw = new CodeWriter();

            cw.WriteLine("using System.CodeDom.Compiler;");
            cw.WriteLine("using System.Net;");
            cw.WriteLine("using System.Threading.Tasks;");

            cw.WriteLine("using Microsoft.AspNetCore.Mvc;");
            cw.WriteLine("using Microsoft.EntityFrameworkCore;");

            cw.WriteLine($"using {dossier.Info.Namespace}.Dal;");
            cw.WriteLine($"using {dossier.Info.Namespace}.Models;");

            cw.WriteLine($"namespace {dossier.Info.Namespace}.Controllers");
            cw.Open();

            cw.CodeCoverage();
            cw.WriteLine($"public partial class {viewGroup.Name}Controller : Controller");
            cw.Open();

            string databaseName = viewGroup.Parent.DatabaseInfo?.Name;

            cw.WriteLine($"private {databaseName}Context db = new {databaseName}Context();");

            foreach (IViewInfo view in viewGroup.Views)
            {
                IMvcViewMold viewMold = Views.Create(view);
                viewMold.CreateController(cw, view);
            }

            cw.Close();

            cw.Close();

            pallet.AddProduct("MvcController", "Controllers", $@"{viewGroup.Name}Controller.cs", cw);
        }
    }
}