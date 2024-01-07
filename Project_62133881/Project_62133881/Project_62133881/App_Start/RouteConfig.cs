using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Project_62133881
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapMvcAttributeRoutes(); // Bổ sung

            routes.MapRoute(
                name: "XemChiTiet",
                url: "{tensp}-{id}",
                defaults: new { controller = "SanPham_62133881", action = "XemChiTiet", id = UrlParameter.Optional }
            );

            //Mặc định
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home_62133881", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
