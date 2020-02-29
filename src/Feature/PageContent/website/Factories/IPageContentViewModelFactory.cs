using PSGN.Feature.PageContent.Models;
using PSGN.Feature.PageContent.ViewModels;

namespace PSGN.Feature.PageContent.Factories
{
    public interface IPageContentViewModelFactory
    {
        ImageLinkViewModel CreateImageLinkViewModel(IImageLink imageLinkItemDataSource, bool isExperienceEditor);
        LinkItemViewModel CreateLinkItemViewModel(ILinkItem datasource, bool isExperienceEditor);
    }
}