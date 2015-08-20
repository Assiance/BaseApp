using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BaseApp.DAL.Contexts;
using BaseApp.Domain.Models;
using BaseApp.Web.Filters;
using BaseApp.Web.Infrastructure.Alerts;
using BaseApp.Web.Infrastructure.Controllers;

namespace BaseApp.Web.Controllers
{
    public class ExampleController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Examples
        public ActionResult Index()
        {
            return View(db.Examples.ToList());
        }

        // GET: Examples/Details/5
        [Log("Viewed example {id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Example example = db.Examples.Find(id);
            if (example == null)
            {
                return HttpNotFound();
            }
            return View(example);
        }

        // GET: Examples/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Examples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Log("Created example")]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName")] Example example)
        {
            if (ModelState.IsValid)
            {
                db.Examples.Add(example);
                db.SaveChanges();

                //this.RedirectToAction<HomeController>(a => a.Index()); would redirect to HomeController Index
                return RedirectToAction<ExampleController>(c => c.Index()).WithSuccess("Example Created");
            }

            return View(example).WithError("Error with example");
        }

        // GET: Examples/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Example example = db.Examples.Find(id);
            if (example == null)
            {
                return HttpNotFound().WithError("Example not found");
            }
            return View(example);
        }

        // POST: Examples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName")] Example example)
        {
            if (ModelState.IsValid)
            {
                db.Entry(example).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction<ExampleController>(c => c.Index()).WithSuccess("Example Edited");
            }
            return View(example).WithError("Error with Example");
        }

        // GET: Examples/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Example example = db.Examples.Find(id);
            if (example == null)
            {
                return HttpNotFound().WithError("Example not found");
            }
            return View(example);
        }

        // POST: Examples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Log("Deleted example {id}")]
        public ActionResult DeleteConfirmed(int id)
        {
            Example example = db.Examples.Find(id);
            db.Examples.Remove(example);
            db.SaveChanges();
            return RedirectToAction<ExampleController>(a => a.Index()).WithSuccess("Example deleted");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
