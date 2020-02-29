using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Sitecore.Pipelines;

namespace KATSU.Feature.Package.Routes
{
    public class RegisterRoutes
    {
        /// <summary>
        ///     This route is NOT required for the Package feature, it is only here as an example of how to
        ///     register a custom route. You can access it using http://{host}/ApiTest/CustomRoute/Package/SomeParam
        ///     We can also use Sitecore native rather than a custom route http://{host}/api/sitecore/Package/TestAction
        /// </summary>
        /// <param name="args"></param>
        public void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapRoute("Feature.Package", "ApiTest/CustomRoute/Package/{someParam}",
                new { controller = "PackageAPI", action = "TestAction", someParam = RouteParameter.Optional });
        }
    }
}
