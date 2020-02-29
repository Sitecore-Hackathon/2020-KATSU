﻿using Glass.Mapper.Sc;
using KATSU.Feature.PageContent.Models;
using KATSU.Feature.PageContent.ViewModels;

namespace KATSU.Feature.PageContent.Factories
{
    public class PageContentViewModelFactory : IPageContentViewModelFactory
    {
        private readonly IGlassHtml _glassHtml;

        public PageContentViewModelFactory(IGlassHtml glassHtml)
        {
            _glassHtml = glassHtml;
        }

        public ImageLinkViewModel CreateImageLinkViewModel(IImageLink ImageLinkItemDataSource, bool isExperienceEditor)
        {
            return new ImageLinkViewModel
            {
                Image = ImageLinkItemDataSource.Image,
                Link = ImageLinkItemDataSource.Link,
                CssClass = ImageLinkItemDataSource.CssClass,
                IsExperienceEditor = isExperienceEditor
            };
        }

        public LinkItemViewModel CreateLinkItemViewModel(ILinkItem datasource, bool isExperienceEditor)
        {
            return new LinkItemViewModel
            {
                Image = datasource.Image?.Src,
                Link = datasource.Link,
                Name = datasource.LinkName,
                IsExperienceEditor = isExperienceEditor
            };
        }

    }
}