using Autofac;
using Autofac.Integration.WebApi;
using EmployeeTracker.API.Autofac;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace EmployeeTracker.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.EnableCors();

            // use camel case for JSON data
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
              new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            /*** Autofac: Build the container ***/
            var builder = new ContainerBuilder();

            // register Web API Controllers
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly());

            // register your classes and expose their interfaces - shared
            builder.RegisterModule(new StandardModule());

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
