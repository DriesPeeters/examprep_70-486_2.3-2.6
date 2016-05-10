using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace examprep_70_486
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("Android")
            {
                ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf("Android", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("Edge")
            {
                ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf("Edge", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("Mobile")
            {
                ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf("Windows Phone", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }
    }
}
