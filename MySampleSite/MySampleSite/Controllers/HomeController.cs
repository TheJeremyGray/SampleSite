using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Elmah;

namespace MySampleSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "";
           
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [Authorize(Roles = "Administrators")]
        public ActionResult Administration()
        {
            return View();
        }
    }
}
