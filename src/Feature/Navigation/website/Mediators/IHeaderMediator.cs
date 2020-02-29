using KATSU.Feature.Navigation.ViewModels;
using KATSU.Foundation.Core.Models;

namespace KATSU.Feature.Navigation.Mediators
{
    public interface IHeaderMediator
    {
        MediatorResponse<HeaderViewModel> RequestHeaderViewModel();
    }
}