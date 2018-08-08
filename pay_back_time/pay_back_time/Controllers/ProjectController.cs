using ProjectLib.PModels;
using ProjectLib.PServiceFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pay_back_time.Controllers
{
    public class ProjectController : Controller
    {
        IProjectService service = new ProjectService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(ProjectModel model)
        {
            service.AddProject(model);
            return RedirectToAction("Projects", "Home");
        }

        public ActionResult DeleteProject(int id)
        {
            ProjectModel model = service.GetProject(id);
            service.DeleteProject(model);
            return RedirectToAction("Projects", "Home");
        }

        public ActionResult EditForm(int id)
        {
            ProjectModel model = service.GetProject(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateProduct(ProjectModel model)
        {
            service.UpdateProject(model);
            return RedirectToAction("Projects", "Home");
        }
    }
}