﻿using ProjectLib.PModels;
using ProjectLib.PServiceFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pay_back_time.Controllers
{
    public class HomeController : Controller
    {
        IProjectService service = new ProjectService();
        public ActionResult Index()
        {
            ProjectModel mod = new ProjectModel();
            return View();
        }

        public ActionResult Projects()
        {
            ProjectListModel model = service.GetProjects();
            return View(model);
        }

        public ActionResult SuccessfulProjects()
        {
            ProjectListModel model = service.GetProjects();
            return View(model);
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}