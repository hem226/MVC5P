using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.ActionFilters;

namespace WebApplication2.Controllers
{
    [MyFilter]
    public class AFController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.msg = "AF Page";
            System.IO.File.AppendAllText(@"C:\Users\Admin\Downloads\MyFilter.log", ViewBag.msg);
            //try
            //{
            //    var a = 0;
            //    var b = 1 / a;
            //}
            //catch (Exception)
            //{

            //    return Content("Exception");
            //}
            return RedirectToAction("Page1");
        }

        public ActionResult Page1()
        {
            ViewBag.msg = "Page1 !!!!";
            return View();
        }
    }
}