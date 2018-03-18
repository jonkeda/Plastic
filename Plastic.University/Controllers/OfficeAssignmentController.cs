using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Dal;
using ContosoUniversity.Models;
namespace ContosoUniversity.Controllers
{
    [GeneratedCode("","")]
    public partial class OfficeAssignmentController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public async Task<ActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind] OfficeAssignment data)
        {
            if (ModelState.IsValid)
            {
                db.OfficeAssignments.Add(data);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }
            OfficeAssignment item = await db.OfficeAssignments.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
        // Edit
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }
            OfficeAssignment item = await db.OfficeAssignments.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(OfficeAssignment data)
        {
            db.Entry(data).State = EntityState.Deleted;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Index()
        {
            var data = db.OfficeAssignments;
            return View(await data.ToListAsync());
        }
    }
}
