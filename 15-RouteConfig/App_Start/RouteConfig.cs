using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _15_RouteConfig
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Products",
                url: "{ProductName}--p--{ProductId}", //Details method parametre içi..
                defaults: new
                {
                    controller = "Product",
                    action = "Details",
                    ProductName = UrlParameter.Optional,
                    ProductId = UrlParameter.Optional
                }
                );

            routes.MapRoute(
                name: "Bilal",
                url: "Bilal",
                defaults:new 
                { controller = "Product",
                    action = "Index" }
                );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
