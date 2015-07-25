using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MBController : Controller
    {
        // GET: MB
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SampleVM data)
        {
            if(ModelState.IsValid)
            {
                TempData["IndexSaveMsg"] = "新增" + data.name + "成功";
                return RedirectToAction("IndexResult");
            }

            return View(data);
        }

        public ActionResult IndexResult()
        {
            return View();
        }

    }
}