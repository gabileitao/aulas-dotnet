﻿using System.Web.Http;

namespace API1 {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            config.MapHttpAttributeRoutes();
            //config.Routes.MapHttpRoute(
            //    name: null,
            //    routeTemplate: "{controller}/{action}"
            //);
        }
    }
}
