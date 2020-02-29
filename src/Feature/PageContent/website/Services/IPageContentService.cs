using PSGN.Feature.PageContent.Models;
using PSGN.Foundation.Search.Models;

namespace PSGN.Feature.PageContent.Services
{
    public interface IPageContentService
    {
        IImageLink GetImageLinkItem();
        bool IsExperienceEditor { get; }
    }
}