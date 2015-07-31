using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.RouteExistingFiles = true;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            //routes.MapRoute("AddControllersRoute", "Home/{action}/{id}/{*catchall}",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    },
            //    new[] { "UrlsAndRoutes.AdditionalControllers" });

            //Route myRoute = routes.MapRoute("MyRoute", "{controller}/{Action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new {  
            //            customConstraint = new UserAgentConstraint("Chrome")
            //        }, 
            //    new[] { "UrlsAndRoutes.AdditionalControllers" });

            //myRoute.DataTokens["UseNamespaceFallback"] = false;

            ////routes.MapRoute("DiskFile", "Content/StaticContent.html",
            ////    new { controller = "Customer", action = "List" });

            ////routes.MapRoute("ChromeRoute", "{*catchall}",
            ////    new { controller = "Home", action = "Index" },
            ////    new { customConstraint = new UserAgentConstraint("Chrome") },
            ////    new[] { "UrlsAndRoutes.AdditionalControllers" });

            ////routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            ////    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            ////    new[] { "UrlsAndRoutes.Controllers" });

            //routes.MapRoute("NewRoute", "App/Do{action}",
            //    new { controller = "Home" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}",
            //    new { controller="Home", action="Index", id=UrlParameter.Optional});

            routes.Add(new LegacyRoute(
                "~/articles/Windows_3.1_Overview.html",
                "~/old/.Net_1.0_Class_Library"));

            routes.MapRoute("MyRoute", "{controller}/{action}");
            routes.MapRoute("MyOtherRoute", "App/{action}", new { controller = "Home" });
        }
    }
}