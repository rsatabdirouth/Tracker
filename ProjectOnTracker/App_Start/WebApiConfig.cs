using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using ProjectOnTracker.Models;
using ProjectOnTracker.ViewModels;
using System.Net.Http.Headers;
using System.Web.Http.Cors;

namespace ProjectOnTracker
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
          
            config.EnableCors();

            config.Formatters.JsonFormatter
                                   .SerializerSettings
                                   .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new
                                  MediaTypeHeaderValue("text/html"));

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }

            );
        //    config.EnableQuerySupport();
        }
    }
}
