using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.ActionFilters
{
    public class MyFilterAttribute : ActionFilterAttribute, IExceptionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var mm = filterContext.Controller.ViewBag + " - OnActionExecuting - " + filterContext.RouteData.Values["controller"] + " - " + filterContext.RouteData.Values["action"] + "\n";
            File.AppendAllText(@"C:\Users\Admin\Downloads\MyFilter.log", mm);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var mm = filterContext.Controller.ViewBag + " - OnActionExecuted - " + filterContext.RouteData.Values["controller"] + " - " + filterContext.RouteData.Values["action"] + "\n";
            File.AppendAllText(@"C:\Users\Admin\Downloads\MyFilter.log", mm);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var mm = filterContext.Controller.ViewBag + " - OnResultExecuting - " + filterContext.RouteData.Values["controller"] + " - " + filterContext.RouteData.Values["action"] + "\n";
            File.AppendAllText(@"C:\Users\Admin\Downloads\MyFilter.log", mm);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var mm = filterContext.Controller.ViewBag + " - OnResultExecuted - " + filterContext.RouteData.Values["controller"] + " - " + filterContext.RouteData.Values["action"] + "\n";
            File.AppendAllText(@"C:\Users\Admin\Downloads\MyFilter.log", mm);
        }

        public void OnException(ExceptionContext filterContext)
        {
            var mm = filterContext.Controller.ViewBag + " - OnException - " + filterContext.RouteData.Values["controller"] + " - " + filterContext.RouteData.Values["action"] + "\n";
            File.AppendAllText(@"C:\Users\Admin\Downloads\MyFilter.log", mm);
        }
    }
}