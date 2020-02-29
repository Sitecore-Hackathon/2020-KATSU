using KATSU.Feature.PageContent.Models;
using KATSU.Feature.PageContent.ViewModels;

namespace KATSU.Feature.PageContent.Factories
{
    public interface IPageContentViewModelFactory
    {
        ImageLinkViewModel CreateImageLinkViewModel(IImageLink imageLinkItemDataSource, bool isExperienceEditor);
        LinkItemViewModel CreateLinkItemViewModel(ILinkItem datasource, bool isExperienceEditor);
    }
}