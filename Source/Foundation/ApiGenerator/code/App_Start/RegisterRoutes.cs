using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace SitecoreMaster.Foundation.ApiGenerator.App_Start
{
    public class RegisterRoutes
    {
        public virtual void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapHttpRoute("ApiGenerator", "api/generator/{definition}/{path}", new { controller = "ApiGenerator", action = "Generate" });
        }
    }
}