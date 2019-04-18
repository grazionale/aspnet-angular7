﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SotranTeste
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web

            config.EnableCors(new EnableCorsAttribute("http://localhost:4200", headers: "*", methods: "*"));

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );



        }
    }
}
