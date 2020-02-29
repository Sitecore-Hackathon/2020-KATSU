using System.Web.Mvc;
using Sitecore.Mvc.Controllers;

namespace KATSU.Feature.Package.Controllers
{
    public class PackageAPIController : SitecoreController
    {
        /// <summary>
        /// Not used, here to demonstrate routes found in RegisterRoutes.cs
        /// </summary>
        /// <returns></returns>
        public ActionResult TestAction(string someParam)
        {
            return Content($"This is a test {someParam}");
        }
    }
}
