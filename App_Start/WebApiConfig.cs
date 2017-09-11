using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
// to consume JSON
using Newtonsoft.Json.Serialization;

namespace VideoApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //JSON
            var setting = config.Formatters.JsonFormatter.SerializerSettings;
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            setting.Formatting = Newtonsoft.Json.Formatting.Indented;
            
            //end
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
