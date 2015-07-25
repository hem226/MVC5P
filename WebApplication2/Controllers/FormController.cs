using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FormController : BaseController
    {
        public ActionResult Index(SampleVM data)
        {
            var aa = new SampleVM() { name = "aaa", title = "aaa" };
            ViewData["Name"] = "John";

            ViewData["ListItem"] = new SelectList(db.Occupation.ToList(), "OccupationId", "OccupationName");

            return View();
        }

    }
}