using ProjectLib.PModels;
using ProjectLib.PServiceFolder;
using System;
using System.Collections.Generic;
using System.IO;
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

        [Authorize(Roles = "Admin")]
        public ActionResult AddProject()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult AddProject(ProjectModel model)
        {
            var fileName = Path.GetFileName(model.UploadedFile.FileName);
            var path = Path.Combine(Server.MapPath("~/Content/Images/"), fileName);
            model.UploadedFile.SaveAs(path);
            model.Image = "/Content/Images/" + fileName;
            service.AddProject(model);
            return RedirectToAction("Projects", "Home");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult DeleteProject(int id)
        {
            ProjectModel model = service.GetProject(id);
            service.DeleteProject(model);
            return RedirectToAction("Projects", "Home");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult EditProject(int id)
        {
            ProjectModel model = service.GetProject(id);
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult EditProject(ProjectModel model)
        {
            if(!(model.UploadedFile == null))
            {
                var fileName = Path.GetFileName(model.UploadedFile.FileName);
                if(!string.IsNullOrEmpty(fileName))
                {
                    model.Image = "/Content/Images/" + fileName;
                }
                var path = Path.Combine(Server.MapPath("~/Content/Images/"), fileName);
                model.UploadedFile.SaveAs(path);
            }   

            service.UpdateProject(model);
            return RedirectToAction("Projects", "Home");
        }
    }
}