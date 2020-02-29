using System.Web.Mvc;
using KATSU.Feature.Package.Mediators;
using KATSU.Foundation.Core.Exceptions;
using Sitecore.Mvc.Controllers;

namespace KATSU.Feature.Package.Controllers
{
    public class PackageController : SitecoreController
    {
        private readonly IPackageMediator _packageMediator;

        public PackageController()
        {

        }

        [HttpGet]
        public ActionResult EntityDetails(string id, bool isNew = false)
        {
            var mediatorResponse = _packageMediator.RequestPackageViewModel(id);

            switch (mediatorResponse.Code)
            {
                case Constants.MediatorCodes.PackageResponse.DataSourceError:
                case Constants.MediatorCodes.PackageResponse.ViewModelError:
                    return View("~/views/Package/Error.cshtml");
                case Constants.MediatorCodes.PackageResponse.Ok:
                    return View(mediatorResponse.ViewModel);
                default:
                    throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            }
        }
    }
}
