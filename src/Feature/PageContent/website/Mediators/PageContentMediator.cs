using KATSU.Feature.PageContent.Factories;
using KATSU.Feature.PageContent.Models;
using KATSU.Feature.PageContent.Services;
using KATSU.Feature.PageContent.ViewModels;
using KATSU.Foundation.Content.Repositories;
using KATSU.Foundation.Core.Models;
using KATSU.Foundation.Core.Services;

namespace KATSU.Feature.PageContent.Mediators
{
    public class PageContentMediator : IPageContentMediator
    {
        private readonly IPageContentService _imageLinkService;
        private readonly IMediatorService _mediatorService;
        private readonly IPageContentViewModelFactory _imageLinkViewModelFactory;
        private readonly IRenderingRepository _renderingRepository;

        public PageContentMediator(IPageContentService imageLinkService
            , IMediatorService mediatorService
           , IPageContentViewModelFactory imageLinkViewModelFactory
            , IRenderingRepository renderingRepository)
        {
            _imageLinkService = imageLinkService;
            _mediatorService = mediatorService;
            _imageLinkViewModelFactory = imageLinkViewModelFactory;
            _renderingRepository = renderingRepository;
        }

        /// <summary>
        ///     Mediator pattern is overkill in this instance, but here as an example to return response codes to a controller, and
        ///     keep the controller dumb as a result
        /// </summary>
        /// <returns>A mediator response with the result of the view model instantiation</returns>
        public MediatorResponse<ImageLinkViewModel> RequestImageLinkViewModel()
        {
            var imageLinkItemDataSource = _imageLinkService.GetImageLinkItem();

            if (imageLinkItemDataSource == null)
                return _mediatorService.GetMediatorResponse<ImageLinkViewModel>(MediatorCodes.ImageLinkResponse.DataSourceError);

            var viewModel =
                _imageLinkViewModelFactory.CreateImageLinkViewModel(imageLinkItemDataSource, _imageLinkService.IsExperienceEditor);

            if (viewModel == null)
                return _mediatorService.GetMediatorResponse<ImageLinkViewModel>(MediatorCodes.ImageLinkResponse.ViewModelError);

            return _mediatorService.GetMediatorResponse(MediatorCodes.ImageLinkResponse.Ok, viewModel);
        }

        public MediatorResponse<LinkItemViewModel> RequestLinkItemViewModel()
        {
            var dateSource = _renderingRepository.GetDataSourceItem<ILinkItem>();
            
            var viewModel =
               _imageLinkViewModelFactory.CreateLinkItemViewModel(dateSource, _imageLinkService.IsExperienceEditor);


            return _mediatorService.GetMediatorResponse(MediatorCodes.ImageLinkResponse.Ok, viewModel);
        }

    }
}