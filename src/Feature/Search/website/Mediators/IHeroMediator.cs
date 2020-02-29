using KATSU.Feature.Hero.ViewModels;
using KATSU.Foundation.Core.Models;

namespace KATSU.Feature.Hero.Mediators
{
    public interface IHeroMediator
    {
        MediatorResponse<HeroViewModel> RequestHeroViewModel();
    }
}
