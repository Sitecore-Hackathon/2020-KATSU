using Glass.Mapper.Sc;
using KATSU.Feature.Navigation.Models;
using KATSU.Feature.Navigation.ViewModels;

namespace KATSU.Feature.Navigation.Factories
{
    public class HeaderViewModelFactory : IHeaderViewModelFactory
    {
        private readonly IGlassHtml _glassHtml;
        public HeaderViewModelFactory(IGlassHtml glassHtml)
        {
            _glassHtml = glassHtml;
        }
        public HeaderViewModel CreateHeaderViewModel(IHeader HeaderItemDataSource, bool isExperienceEditor)
        {
            return new HeaderViewModel
            {              
                Language =   HeaderItemDataSource.Language,
                Copyrights = HeaderItemDataSource.Copyrights,
                HeaderItems= HeaderItemDataSource.HeaderItems,
                FooterItems= HeaderItemDataSource.FooterItems,
                IsExperienceEditor = isExperienceEditor
            };
        }
    }
}