using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //this is i define attribute route...>
            routes.MapMvcAttributeRoutes();

           /* 
            * this is the defination of how to make custom route basically...but bcs if we working with larger database ,it becomes a headache...so microsoft basically
            * defines a update of custom route is attribute route.....
            * routes.MapRoute(
                "moviesbyreleasedata",
                "movies/released/{Year}/{Month}",
                new { Controller = "Movies", action = "Byreleasedate" },
                new { Year = @"2015|2017", Month = @"\d{2}" }); */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
