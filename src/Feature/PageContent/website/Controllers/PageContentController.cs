using KATSU.Feature.PageContent.Mediators;
using KATSU.Feature.PageContent.Models;
using KATSU.Foundation.Content.Repositories;
using KATSU.Foundation.Core.Exceptions;
using Sitecore.Mvc.Controllers;
using System.Collections.Generic;
using System.Web.Mvc;
using Sitecore.Data.Items;
using System.Linq;
using KATSU.Feature.PageContent.ViewModels;
using Sitecore.Links;

namespace KATSU.Feature.PageContent.Controllers
{
    public class PageContentController : SitecoreController
    {
        private readonly IPageContentMediator _PageContentMediator;


        public PageContentController(IPageContentMediator pageContentMediator)
        {
            _PageContentMediator = pageContentMediator;
        }

        public ActionResult BodyHeaderNavigation()
        {
            var mediatorResponse = _PageContentMediator.RequestLinkItemViewModel();

            switch (mediatorResponse.Code)
            {
                case MediatorCodes.ImageLinkResponse.DataSourceError:
                case MediatorCodes.ImageLinkResponse.ViewModelError:
                    return View("~/views/ImageLink/Error.cshtml");
                case MediatorCodes.ImageLinkResponse.Ok:
                    return View(mediatorResponse.ViewModel);
                default:
                    throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            }

        }

        public ActionResult ImageLink()
        {
            var mediatorResponse = _PageContentMediator.RequestImageLinkViewModel();

            switch (mediatorResponse.Code)
            {
                case MediatorCodes.ImageLinkResponse.DataSourceError:
                case MediatorCodes.ImageLinkResponse.ViewModelError:
                    return View("~/views/ImageLink/Error.cshtml");
                case MediatorCodes.ImageLinkResponse.Ok:
                    return View(mediatorResponse.ViewModel);
                default:
                    throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            }
        }

        public ActionResult Breadcrumb()
        {
            List<Item> items = GetBreadcrumbItems();

            var breadcurmbs = items.Select(e => new BreadcrumbViewModel
            {
                Title = string.IsNullOrEmpty(e["Title"]) ? e.DisplayName : e["Title"],
                IsActive = Sitecore.Context.Item.ID == e.ID,
                Url = LinkManager.GetItemUrl(e)
            }).ToList();

            var currentItem = Sitecore.Context.Item;

            breadcurmbs.Add(new BreadcrumbViewModel
            {
                Title = currentItem["Title"],
                IsActive = Sitecore.Context.Item.ID == currentItem.ID,
                Url = LinkManager.GetItemUrl(currentItem)
            });

            return View("~/Views/BreadCrumbs.cshtml", breadcurmbs);
        }

        private List<Item> GetBreadcrumbItems()
        {
            string homePath = Sitecore.Context.Site.StartPath;
            Item homeItem = Sitecore.Context.Database.GetItem(homePath);

            if (homeItem != null)
            {
                List<Item> items = Sitecore.Context.Item.Axes.GetAncestors()
                  .SkipWhile(item => item.ID != homeItem.ID)
                  .ToList();
                items.Remove(items.First());
                return items;
            }

            return new List<Item>();
        }
    }
}