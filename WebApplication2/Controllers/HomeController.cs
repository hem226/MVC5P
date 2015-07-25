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
        [HandleError(View="Error2", ExceptionType=typeof(ArgumentException))]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new ArgumentException("Error");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewLayout()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
    }
}