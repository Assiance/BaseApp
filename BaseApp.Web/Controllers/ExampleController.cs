using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using BaseApp.Web.Infrastructure.Alerts;

using Microsoft.Web.Mvc;
using BaseApp.DAL.Contexts;
using BaseApp.Domain.Models;

namespace BaseApp.Web.Controllers
{
    public class ExampleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Examples
        public ActionResult Index()
        {
            return View(db.Examples.ToList());
        }

        // GET: Examples/Details/5
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName")] Example example)
        {
            if (ModelState.IsValid)
            {
                db.Examples.Add(example);
                db.SaveChanges();

                //this.RedirectToAction<HomeController>(a => a.Index()); would redirect to HomeController Index
                return this.RedirectToAction(c => c.Index()).WithSuccess("Example Created");
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
                return this.RedirectToAction(c => c.Index()).WithSuccess("Example Edited");
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
        public ActionResult DeleteConfirmed(int id)
        {
            Example example = db.Examples.Find(id);
            db.Examples.Remove(example);
            db.SaveChanges();
            return this.RedirectToAction(a => a.Index()).WithSuccess("Example deleted");
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
