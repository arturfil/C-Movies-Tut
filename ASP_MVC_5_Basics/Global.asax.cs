using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ASP_MVC_5_Basics.Models;

namespace ASP_MVC_5_Basics
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()

        {
            Database.SetInitializer<MovieDBContext>(new DropCreateDatabaseIfModelChanges<MovieDBContext>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
