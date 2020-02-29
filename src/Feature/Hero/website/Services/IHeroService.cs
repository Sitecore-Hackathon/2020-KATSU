using KATSU.Feature.Hero.Models;
using KATSU.Foundation.Search.Models;

namespace KATSU.Feature.Hero.Services
{
    public interface IHeroService
    {
        IHero GetHeroItems();
        BaseSearchResultItem GetHeroImagesSearch();
        bool IsExperienceEditor { get; }
    }
}
