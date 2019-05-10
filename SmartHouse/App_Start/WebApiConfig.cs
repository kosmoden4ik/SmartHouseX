using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SmartHouse
{
    public static class WebApiConfig
    {
        public static  int a = 1;
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
             
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        public class AppController : ApiController
        {
          
            [HttpGet]
            public string getUser()
            {
                return "MacAddress "+a;
            }
            [HttpGet]
            public void getText()
            {
                a++;
                getUser();
            }
        }

    }
}
