using KATSU.Feature.Package.Mediators;
using KATSU.Foundation.Core.Exceptions;
using Sitecore.Mvc.Controllers;
using System.Web.Mvc;
using static KATSU.Feature.Packages.Constants;

namespace KATSU.Feature.Package.Controllers
{
    public class PackageController : SitecoreController
    {

        private readonly IPackageMediator _packageMediator;

        public PackageController(IPackageMediator packageMediator)
        {
            _packageMediator = packageMediator;
        }
        public ActionResult PackageSearchList(string query)
        {
            var mediatorResponse = _packageMediator.RequestPackageViewModel(query);

            switch (mediatorResponse.Code)
            {
                case MediatorCodes.PackageSearchResponse.DataSourceError:
                case MediatorCodes.PackageSearchResponse.ViewModelError:
                    return View("~/views/Package/Error.cshtml");
                case MediatorCodes.PackageSearchResponse.Ok:
                    return View(mediatorResponse.ViewModel);
                default:
                    throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            }
        }
    }
}
