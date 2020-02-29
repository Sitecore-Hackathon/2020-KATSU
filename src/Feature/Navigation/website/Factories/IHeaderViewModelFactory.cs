using KATSU.Feature.Navigation.Models;
using KATSU.Feature.Navigation.ViewModels;

namespace KATSU.Feature.Navigation.Factories
{
    public interface IHeaderViewModelFactory
    {
        HeaderViewModel CreateHeaderViewModel(IHeader HeaderItemDataSource, bool isExperienceEditor);       
    }
}