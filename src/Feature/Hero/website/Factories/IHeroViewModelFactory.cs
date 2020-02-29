using KATSU.Feature.Hero.Models;
using KATSU.Feature.Hero.ViewModels;

namespace KATSU.Feature.Hero.Factories
{
    public interface IHeroViewModelFactory
    {
        HeroViewModel CreateHeroViewModel(IHero heroItemDataSource, bool isExperienceEditor);
    }
}
