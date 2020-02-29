using KATSU.Feature.Package.Mediators;
using KATSU.Foundation.Core.Exceptions;
using Sitecore.Mvc.Controllers;
using System.Web.Mvc;

namespace KATSU.Feature.Package.Controllers
{
    public class PackageController : SitecoreController
    {
        private readonly IPackageMediator _packageMediator;

        public PackageController(IPackageMediator packageMediator)
        {
            _packageMediator = packageMediator;
        }
        public ActionResult PackageSearchResult(string query)
        {
            var mediatorResponse = _packageMediator.RequestPackageViewModel(query);

            switch (mediatorResponse.Code)
            {
                case Constants.MediatorCodes.PackageSearchResponse.DataSourceError:
                case Constants.MediatorCodes.PackageSearchResponse.ViewModelError:
                    return View("~/views/Package/Error.cshtml");
                case Constants.MediatorCodes.PackageSearchResponse.Ok:
                    return View(mediatorResponse.ViewModel);
                default:
                    throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            }
        }

        [HttpGet]
        public ActionResult PackageDetails(string id = null, bool isNew = false)
        {
            if (id == null)
                return View("~/views/Package/Error.cshtml");

            var mediatorResponse = _packageMediator.RequestPackageDetailsViewModel(id);

            switch (mediatorResponse.Code)
            {
                case Constants.MediatorCodes.PackageSearchResponse.DataSourceError:
                case Constants.MediatorCodes.PackageSearchResponse.ViewModelError:
                    return View("~/views/Package/Error.cshtml");
                case Constants.MediatorCodes.PackageSearchResponse.Ok:
                    return View(mediatorResponse.ViewModel);
                default:
                    throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            }
        }
    }
}
