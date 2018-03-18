using Plastic.Infos.Views;
using Plastic.Molding.Views;

namespace Plastic.Molding.Cs.Views.Mvc
{
    public interface IMvcViewMold : IViewMold
    {
        void CreateController(CodeWriter cw, IViewInfo view);

        void CreateHtmlView(CodeWriter cw, IViewInfo view);
    }

    public class MvcViewMold<T> : MvcMold<T>, IMvcViewMold
        where T : IViewInfo
    {
        public static MvcPanelMoldCollection PanelMolds { get; } = new MvcPanelMoldCollection();

        public void Manufacture(IViewInfo viewInfo, Dossier dossier)
        {

        }

        public virtual void CreateController(CodeWriter cw, IViewInfo view)
        {
            cw.WriteLine($"// {view.Name}");
        }

        public virtual void CreateHtmlView(CodeWriter cw, IViewInfo view)
        {
            cw.WriteLine($"<!-- {view.Name} -->");
        }
    }

    public class MvcEditViewMold : MvcViewMold<EditViewInfo>
    {
        
    }

    public class MvcDeleteViewMold : MvcViewMold<DeleteViewInfo>
    {
        public override void CreateController(CodeWriter cw, IViewInfo view)
        {
            cw.WriteLine($"public async Task<ActionResult> Delete(int? id)");
            cw.Open();
            cw.WriteLine($"if (id == null)");

            cw.Open();
            cw.WriteLine($"return new StatusCodeResult((int)HttpStatusCode.BadRequest);");
            cw.Close();

            cw.WriteLine($"{view.Table?.Name} item = await db.{view.Table?.Plural}.FindAsync(id);");

            cw.WriteLine($"if (item == null)");
            cw.Open();
            cw.WriteLine($"return NotFound();");
            cw.Close();

            cw.WriteLine($"return View(item);");
            cw.Close();

            cw.WriteLine($"[HttpPost]");
            cw.WriteLine($"[ValidateAntiForgeryToken]");
            cw.WriteLine($"public async Task<ActionResult> Delete({view.Table?.Name} data)");
            cw.Open();

            cw.WriteLine($"db.Entry(data).State = EntityState.Deleted;");
            cw.WriteLine($"await db.SaveChangesAsync();");
            cw.WriteLine($@"return RedirectToAction(""Index"");");

            cw.Close();
        }
    }

    public class MvcCreateViewMold : MvcViewMold<CreateViewInfo>
    {
        public override void CreateController(CodeWriter cw, IViewInfo view)
        {
            cw.WriteLine($"public async Task<ActionResult> Create()");
            cw.Open();
            cw.WriteLine($"return View();");
            cw.Close();

            cw.WriteLine($"[HttpPost]");
            cw.WriteLine($"[ValidateAntiForgeryToken]");
            cw.WriteLine($"public async Task<ActionResult> Create([Bind] {view.Table?.Name} data)");
            cw.Open();

            cw.WriteLine($"if (ModelState.IsValid)");
            cw.Open();
            cw.WriteLine($"db.{view.Table?.Plural}.Add(data);");
            cw.WriteLine($"await db.SaveChangesAsync();");
            cw.WriteLine($@"return RedirectToAction(""Index"");");
            cw.Close();

            cw.WriteLine($"return View();");
            cw.Close();

        }
    }

    public class MvcDetailViewMold : MvcViewMold<DetailViewInfo>
    {
        public override void CreateController(CodeWriter cw, IViewInfo view)
        {
            cw.WriteLine($"public async Task<ActionResult> Details(int? id)");
            cw.Open();
            cw.WriteLine($"if (id == null)");

            cw.Open();
            cw.WriteLine($"return new StatusCodeResult((int)HttpStatusCode.BadRequest);");
            cw.Close();

            cw.WriteLine($"{view.Table?.Name} item = await db.{view.Table?.Plural}.FindAsync(id);");

            cw.WriteLine($"if (item == null)");
            cw.Open();
            cw.WriteLine($"return NotFound();");
            cw.Close();

            cw.WriteLine($"return View(item);");
            cw.Close();
        }

    }

    public class MvcIndexViewMold : MvcViewMold<IndexViewInfo>
    {
        public override void CreateController(CodeWriter cw, IViewInfo view)
        {
            cw.WriteLine("public async Task<ActionResult> Index()");
            cw.Open();
            cw.WriteLine($"var data = db.{view.Table?.Plural};");
            cw.WriteLine("return View(await data.ToListAsync());");
            cw.Close();
        }
    }
}