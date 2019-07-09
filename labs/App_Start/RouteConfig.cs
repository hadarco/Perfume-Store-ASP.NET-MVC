using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace labs
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config");


         //   routes.MapRoute
         //(
         //name: "DefaultPage",
         //url: "",
         //defaults: new { controller = "Home", action = "Home", id = UrlParameter.Optional }
         //);


            //routes.MapRoute
            //(
            //name: "Add Product",
            //url: "",
            //defaults: new { controller = "Product", action = "Submit", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }

    }
}



