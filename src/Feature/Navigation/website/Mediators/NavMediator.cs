using KATSU.Feature.Navigation.Factories;
using KATSU.Feature.Navigation.Services;
using KATSU.Feature.Navigation.ViewModels;
using KATSU.Foundation.Core.Models;
using KATSU.Foundation.Core.Services;
using static KATSU.Feature.Navigation.Constants;

namespace KATSU.Feature.Navigation.Mediators
{
    public class NavMediator : INavMediator
    {
        private readonly INavService _NavService;
        private readonly IMediatorService _mediatorService;
        private readonly INavViewModelFactory _NavViewModelFactory;
        public NavMediator(INavService NavService, IMediatorService mediatorService,
            INavViewModelFactory NavViewModelFactory)
        {
            _NavService = NavService;
            _mediatorService = mediatorService;
            _NavViewModelFactory = NavViewModelFactory;
        }
        /// <summary>
        ///     Mediator pattern is overkill in this instance, but here as an example to return response codes to a controller, and
        ///     keep the controller dumb as a result
        /// </summary>
        /// <returns>A mediator response with the result of the view model instantiation</returns>
        public MediatorResponse<NavViewModel> RequestNavViewModel()
        {
            var NavItemDataSource = _NavService.GetNavItems();
            if (NavItemDataSource == null)
                return _mediatorService.GetMediatorResponse<NavViewModel>(MediatorCodes.NavResponse.DataSourceError);
                   var viewModel =
                _NavViewModelFactory.CreateNavViewModel(NavItemDataSource, _NavService.IsExperienceEditor);
            if (viewModel == null)
                return _mediatorService.GetMediatorResponse<NavViewModel>(MediatorCodes.NavResponse.ViewModelError);
                return _mediatorService.GetMediatorResponse(MediatorCodes.NavResponse.Ok, viewModel);
        }
    }
}