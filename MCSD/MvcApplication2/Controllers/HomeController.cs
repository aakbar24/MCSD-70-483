using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
           // ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";


            return "HOW ARE YOU ... TO THE WORLD!!";
        }
        public string name()
        {
            return "this is from account controller NAME";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
