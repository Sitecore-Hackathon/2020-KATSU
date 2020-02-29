using KATSU.Feature.Navigation.Models;
using KATSU.Feature.Navigation.ViewModels;
using System.Collections.Generic;

namespace KATSU.Feature.Navigation.Factories
{
    public interface INavViewModelFactory
    {
        NavViewModel CreateNavViewModel(List<ILinkItems> NavItemDataSource, bool isExperienceEditor);       
    }
}