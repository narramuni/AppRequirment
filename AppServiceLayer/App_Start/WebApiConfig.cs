using DataAccessLayer;
using System.Data.Entity;
using System.Web.Http;

public static class WebApiConfig
{
    public static void Register(HttpConfiguration config)
    {
        // Attribute-based routing should come before any convention-based routing
        config.MapHttpAttributeRoutes();

        Database.SetInitializer(new SampleData());

        // Other route configurations, if needed
        config.Routes.MapHttpRoute(
           name: "DefaultApi",
           routeTemplate: "api/{controller}/{id}",
           defaults: new { id = RouteParameter.Optional }
        );
    }
}
