using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _16_RouteConfig
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "HomePage",
                url: "Anasayfa",
                 defaults: new { controller = "Home", action = "Anasayfa", id = UrlParameter.Optional }
                );
            routes.MapRoute(
               name: "Blog",
               url: "Blog",
                defaults: new { controller = "Home", action = "Blog", id = UrlParameter.Optional }
               );
            routes.MapRoute(
             name: "Contact",
             url: "Iletisim",
              defaults: new { controller = "Home", action = "Iletisim", id = UrlParameter.Optional }
             );
            routes.MapRoute(
             name: "Galery",
             url: "Galeri",
              defaults: new { controller = "Home", action = "Galeri", id = UrlParameter.Optional }
             );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Anasayfa", id = UrlParameter.Optional }
            //);
        }
    }
}
