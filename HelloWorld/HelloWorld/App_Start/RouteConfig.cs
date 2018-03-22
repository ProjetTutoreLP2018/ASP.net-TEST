using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HelloWorld
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{value}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Default2",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index2", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default3",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Home", action = "Index3", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default4",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "ListeClient", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default5",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Home", action = "ChercheClient", id = UrlParameter.Optional }
            );
        }
    }
}
