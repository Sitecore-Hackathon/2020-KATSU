using KATSU.Feature.PageContent.ViewModels;
using KATSU.Foundation.Core.Models;

namespace KATSU.Feature.PageContent.Mediators
{
    public interface IPageContentMediator
    {
        MediatorResponse<ImageLinkViewModel> RequestImageLinkViewModel();
        MediatorResponse<LinkItemViewModel> RequestLinkItemViewModel();
    }
}