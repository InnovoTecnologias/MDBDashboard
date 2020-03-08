using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDBinASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public new ActionResult Profile()
        {
            ViewBag.Message = "Sample page for Profile.";

            return View();
        }

        public ActionResult Tables()
        {
            ViewBag.Message = "Sample page for Tables.";

            return View();
        }

        public ActionResult Maps()
        {
            ViewBag.Message = "Sample page for Maps.";

            return View();
        }

        public ActionResult Orders()
        {
            ViewBag.Message = "Sample page for Orders.";

            return View();
        }
    }
}