using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        //OutputCache 不快取 for IE8
        [OutputCache(NoStore = true, Duration = 0)]
        public ActionResult GetDateTime()
        {
            return Content(DateTime.Now.ToString());
        }
    }
}