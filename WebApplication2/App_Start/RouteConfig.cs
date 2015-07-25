﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
             * http://api.jquery.com/jQuery.each/
             */
            routes.MapRoute(
                name: "Practics1",
                url: "{controller}.{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                },
                constraints: new
                {
                    controller = "Products",
                    id = @"\d+"
                }
            );

            /*
             * http://api.jquery.com/Docs/jQuery-each/
             */
            routes.MapRoute(
                name: "Practics2",
                url: "Docs/{controller}-{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                },
                constraints: new
                {
                    controller = @"Prod.*"
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
