using KATSU.Feature.Navigation.Mediators;
using KATSU.Foundation.Core.Exceptions;
using Sitecore.Mvc.Controllers;
using System.Web.Mvc;
using static KATSU.Feature.Navigation.Constants;

namespace KATSU.Feature.Navigation.Controllers
{
    public class NavigationController : SitecoreController
    {
        private readonly IHeaderMediator _headerMediator;
        private readonly INavMediator _NavMediator;

        public NavigationController(IHeaderMediator headerMediator, INavMediator NavMediator)
        {
            _headerMediator = headerMediator;
            _NavMediator = NavMediator;
        }

        // Header Navigation 
        public ActionResult Header()
        {
            //var mediatorResponse = _headerMediator.RequestHeaderViewModel() ?? _headerMediator.RequestHeaderViewModel();
            //if (mediatorResponse != null)
            //{
            //    switch (mediatorResponse.Code)
            //    {
            //        case MediatorCodes.HeaderResponse.DataSourceError:
            //        case MediatorCodes.HeaderResponse.ViewModelError:
            //            return View("~/views/Navigation/Error.cshtml");
            //        case MediatorCodes.HeaderResponse.Ok:
            //            return View(mediatorResponse.ViewModel);
            //        default:
            //            throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            //    }
            //}
            //else
            //{
                return View("~/views/Navigation/header.cshtml");
            //}
        }

        // Main Nav 
        public ActionResult MainNav()
        {
            return GetNavItems("~/views/Nav/MainNav.cshtml");
        }

        // DropList  Nav 
        public ActionResult DropListNav()
        {
            return GetNavItems("~/views/Nav/DropListNav.cshtml");
        }

        // Footer Navigation 
        public ActionResult Footer()
        {
            //var mediatorResponse = _headerMediator.RequestHeaderViewModel() ?? _headerMediator.RequestHeaderViewModel();
            //if (mediatorResponse != null)
            //{
            //    switch (mediatorResponse.Code)
            //    {
            //        case MediatorCodes.HeaderResponse.DataSourceError:
            //        case MediatorCodes.HeaderResponse.ViewModelError:
            //            return View("~/views/Navigation/Error.cshtml");
            //        case MediatorCodes.HeaderResponse.Ok:
            //            return View(mediatorResponse.ViewModel);
            //        default:
            //            throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            //    }
            //}
            //else
            //{
                return View("~/views/Navigation/Footer.cshtml");
            //}
        }

        //Language Selector For Languge Change
        public ActionResult Language()
        {
            return View("~/views/Navigation/Language.cshtml");
        }

        private ActionResult GetNavItems(string view)
        {
            var mediatorResponse = _NavMediator.RequestNavViewModel() ?? _NavMediator.RequestNavViewModel();
            if (mediatorResponse != null)
            {
                switch (mediatorResponse.Code)
                {
                    case MediatorCodes.NavResponse.DataSourceError:
                    case MediatorCodes.NavResponse.ViewModelError:
                        return View("~/views/Nav/Error.cshtml");
                    case MediatorCodes.NavResponse.Ok:
                        return View(view, mediatorResponse.ViewModel);
                    default:
                        throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
                }
            }
            else
            {
                return View(view);
            }
        }
    }
}