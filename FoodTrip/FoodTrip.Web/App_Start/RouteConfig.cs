using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FoodTrip.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Menu",
            //    url: "Vendor/Menu/{id}",
            //    defaults: new { controller = "Vendor", action = "Menu", id = 0 }
            //    );

            //routes.MapRoute(
            //     name: "CreateMenu",
            //     url: "Vendor/Menu/Create",
            //     defaults: new { controller = "Vendor", action = "Create", id = 0 }
            //     );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = 0 }
            );
        }
    }
}
