using ContactManager.Models;
using ContactManager.Repositories.RepositoriesImplEF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class StudentController : Controller
    {

        private SchoolContext db = new SchoolContext();
        
        //
        // GET: /Student/
        public ViewResult Index()
        {
            return View(db.Students.ToList());
        }

        public ActionResult Details (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // AntiForgeryToken prevent cross-site request attacks and the view needs call Html.AntiForgeryToken() (security issue)
        [ValidateAntiForgeryToken]
        // Bind cmd Remove id from model bind and determine exactly what you need update (is a security issue too)
        public ActionResult Create([Bind(Include = "LastName, FirstMidName, EnrollmentDate")]Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(student);
        }

    }
}
