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
    public partial class StudentController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public async Task<ActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind] Student data)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(data);
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
            Student item = await db.Students.FindAsync(id);
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
            Student item = await db.Students.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Student data)
        {
            db.Entry(data).State = EntityState.Deleted;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Index()
        {
            var data = db.Students;
            return View(await data.ToListAsync());
        }
    }
}
