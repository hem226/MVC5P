using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ARController : BaseController
    {
        // GET: AR
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialViewTest()
        {
            return PartialView("MyPartial");
        }

        public ActionResult FileTest()
        {
            return File(Server.MapPath("~/Content/Jordan.jpg"), "image/jepg", "Jordan.jpg");
        }
    }
}