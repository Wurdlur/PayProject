using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pay_back_time.Controllers
{
    public class ProjectController : Controller
    {
        //Service

        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize(Roles = "Admin")]
        public ActionResult AddProject()
        {
            return View();
        }

        //[Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult EditProject(int id)
        {
            return View();
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult EditProject()
        {
            return View();
        }

        //[Authorize(Roles = "Admin")]
        public ActionResult DeleteProject(int id)
        {
            return View();
        }
    }
}