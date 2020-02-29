using Glass.Mapper.Sc;
using KATSU.Feature.Navigation.Models;
using KATSU.Feature.Navigation.ViewModels;
using System.Collections.Generic;

namespace KATSU.Feature.Navigation.Factories
{
    public class NavViewModelFactory : INavViewModelFactory
    {
        private readonly IGlassHtml _glassHtml;

        public NavViewModelFactory(IGlassHtml glassHtml)
        {
            _glassHtml = glassHtml;
        }
        public NavViewModel CreateNavViewModel(List<ILinkItems> NavItemDataSource, bool isExperienceEditor)
        {
            return new NavViewModel
            {
                MenuItems = NavItemDataSource,
                IsExperienceEditor = isExperienceEditor
            };
        }
    }
}