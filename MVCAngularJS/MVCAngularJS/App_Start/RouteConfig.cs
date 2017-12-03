using System.Web.Mvc;
using System.Web.Routing;

namespace MVCAngularJS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "cart",
               url: "cart/{*catch-all}",
               defaults: new
               {
                   controller = "Cart",
                   action = "Cart"
               });

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
