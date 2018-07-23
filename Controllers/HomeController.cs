using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Page.Controllers
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

        public ActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";
            List<string> countries = new List<string>()
            { "INDIA","USA","FRANCE"};
            ViewData["Message"] = countries;

            return View();
        }
    }
}