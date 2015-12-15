using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BaseApp.Domain.Managers.Interfaces;
using BaseApp.Domain.Models.Domain;
using BaseApp.Domain.Services.Interfaces;
using BaseApp.Web.Infrastructure.Alerts;
using BaseApp.Web.Infrastructure.Controllers;
using BaseApp.Web.Infrastructure.Filters;

namespace BaseApp.Web.Controllers
{
    public class ExampleController : BaseController
    {
        private readonly IExampleService _exampleService;

        public ExampleController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        // GET: Examples
        public ActionResult Index()
        {
            return View(_exampleService.Examples.ToList());
        }

        // GET: Examples/Details/5
        [Log("Viewed example {id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Example example = _exampleService.Examples.FirstOrDefault(x => x.Id == id);

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
                _exampleService.CreateExample(example);

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

            Example example = _exampleService.Examples.FirstOrDefault(x => x.Id == id);

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
                _exampleService.UpdateExample(example);

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

            Example example = _exampleService.Examples.FirstOrDefault(x => x.Id == id);

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
            Example example = _exampleService.Examples.FirstOrDefault(x => x.Id == id);

            _exampleService.DeleteExample(example);

            return RedirectToAction<ExampleController>(a => a.Index()).WithSuccess("Example deleted");
        }
    }
}
