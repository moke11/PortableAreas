using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Action = Antlr.Runtime.Misc.Action;

namespace HelloWorldPlugin
{
    public class HelloWorldAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "HelloWorldPlugin"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute("HelloWorldPlugin_default",
                "HelloWorldPlugin/{controller}/{action}/{id}",
                new
                {
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}