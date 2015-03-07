using ContactManager.Repositories.RepositoriesImplEF;
using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
