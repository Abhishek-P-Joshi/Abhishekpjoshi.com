using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Message = "Resume page.";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Projects page.";

            return View();
        }

        public ActionResult Github()
        {
            ViewBag.Message = "Github page.";

            return View();
        }

        public ActionResult Linkedin()
        {
            ViewBag.Message = "Linkedin page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}