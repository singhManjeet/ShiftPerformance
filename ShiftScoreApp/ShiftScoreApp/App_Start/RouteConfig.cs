using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShiftPerformance
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            //routes.MapRoute(
            //    name: "GetForm",
            //    url: "18YnktzdTc1LFhG12K2eD_kAvyRWIAzdlEBVZFk5sw1U18YnktzdTc1LFhG12K2eD_kAvyRWIAzdlEBVZFk5sw1U",
            //    defaults: new { controller = "ShiftPerformance", action = "Index", id = UrlParameter.Optional }
            //); //GanWeired

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controlle}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
