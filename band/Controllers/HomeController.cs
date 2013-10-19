using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace band.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Login or Create and Join a Band";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About This App.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact the CREATORS!!!.";

            return View();
        }
    }
}
