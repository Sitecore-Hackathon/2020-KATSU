using KATSU.Feature.Navigation.Factories;
using KATSU.Feature.Navigation.Services;
using KATSU.Feature.Navigation.ViewModels;
using KATSU.Foundation.Core.Models;
using KATSU.Foundation.Core.Services;
using static KATSU.Feature.Navigation.Constants;

namespace KATSU.Feature.Navigation.Mediators
{
    public class HeaderMediator : IHeaderMediator
    {
        private readonly IHeaderService _HeaderService;
        private readonly IMediatorService _mediatorService;
        private readonly IHeaderViewModelFactory _HeaderViewModelFactory;
        public HeaderMediator(IHeaderService HeaderService, IMediatorService mediatorService,
            IHeaderViewModelFactory HeaderViewModelFactory)
        {
            _HeaderService = HeaderService;
            _mediatorService = mediatorService;
            _HeaderViewModelFactory = HeaderViewModelFactory;
        }
        /// <summary>
        ///     Mediator pattern is overkill in this instance, but here as an example to return response codes to a controller, and
        ///     keep the controller dumb as a result
        /// </summary>
        /// <returns>A mediator response with the result of the view model instantiation</returns>
        public MediatorResponse<HeaderViewModel> RequestHeaderViewModel()
        {
            var HeaderItemDataSource = _HeaderService.GetHeaderItems();
            if (HeaderItemDataSource == null)
                return _mediatorService.GetMediatorResponse<HeaderViewModel>(MediatorCodes.HeaderResponse.DataSourceError);
                   var viewModel =
                _HeaderViewModelFactory.CreateHeaderViewModel(HeaderItemDataSource, _HeaderService.IsExperienceEditor);
            if (viewModel == null)
                return _mediatorService.GetMediatorResponse<HeaderViewModel>(MediatorCodes.HeaderResponse.ViewModelError);
                return _mediatorService.GetMediatorResponse(MediatorCodes.HeaderResponse.Ok, viewModel);
        }
    }
}