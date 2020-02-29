using PSGN.Feature.PageContent.ViewModels;
using PSGN.Foundation.Core.Models;

namespace PSGN.Feature.PageContent.Mediators
{
    public interface IPageContentMediator
    {
        MediatorResponse<ImageLinkViewModel> RequestImageLinkViewModel();
        MediatorResponse<LinkItemViewModel> RequestLinkItemViewModel();
    }
}