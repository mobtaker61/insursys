using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Insursys
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Login :
            routes.MapRoute(
            name: "_Login",
            url: "login/{action}",
            defaults: new { controller = "_Login", action = "index", id = UrlParameter.Optional }
            );

            //Admin :
            routes.MapRoute(
            name: "Home",
            url: "",
            defaults: new { controller = "_Panel", action = "RS_Dashboard", id = UrlParameter.Optional }
            );

            //Admin :
            routes.MapRoute(
            name: "Panel",
            url: "Panel/{action}",
            defaults: new { controller = "_Panel", action = "RS_Dashboard", id = UrlParameter.Optional }
            );

            //Admin Commander :
            routes.MapRoute(
            name: "PanelCommander",
            url: "PanelCommander/{action}",
            defaults: new { controller = "_PanelCommander", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}
