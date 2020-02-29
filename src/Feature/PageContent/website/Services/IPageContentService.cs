using KATSU.Feature.PageContent.Models;
using KATSU.Foundation.Search.Models;

namespace KATSU.Feature.PageContent.Services
{
    public interface IPageContentService
    {
        IImageLink GetImageLinkItem();
        bool IsExperienceEditor { get; }
    }
}