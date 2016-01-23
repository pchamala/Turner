using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Turner
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            //var json = config.Formatters.JsonFormatter;
            //json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
            //config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Routes.MapHttpRoute(
       name: "Defaultapi",
       routeTemplate: "api/{controller}/{action}/{id}",
       defaults: new { controller = "Titles", id = RouteParameter.Optional }
   );
        }
    }
}
