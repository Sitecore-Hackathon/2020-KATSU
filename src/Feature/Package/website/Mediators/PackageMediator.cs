
using KATSU.Feature.Package.Factories;
using KATSU.Feature.Package.Services;
using KATSU.Feature.Package.ViewModels;
using KATSU.Foundation.Core.Models;
using KATSU.Foundation.Core.Services;
using System.Linq;
using static KATSU.Feature.Packages.Constants;

namespace KATSU.Feature.Package.Mediators
{
    public class PackageMediator : IPackageMediator
    {
        private readonly IPackageService _packageService;
        private readonly IMediatorService _mediatorService;
        private readonly IPackageViewModelFactory _packageViewModelFactory;

        public PackageMediator(IPackageService packageService, IMediatorService mediatorService,
            IPackageViewModelFactory packageViewModelFactory)
        {
            _packageService = packageService;
            _mediatorService = mediatorService;
            _packageViewModelFactory = packageViewModelFactory;
        }

        /// <summary>
        ///     Mediator pattern is overkill in this instance, but here as an example to return response codes to a controller, and
        ///     keep the controller dumb as a result
        /// </summary>
        /// <returns>A mediator response with the result of the view model instantiation</returns>
        public MediatorResponse<PackagesViewModel> RequestPackageViewModel(string query)
        {
            var packageItemDataSource = _packageService.GetPackagesSearch(query);

            if (packageItemDataSource == null && !packageItemDataSource.Any())
                return _mediatorService.GetMediatorResponse<PackagesViewModel>(MediatorCodes.PackageSearchResponse.DataSourceError);

            var viewModel =
                _packageViewModelFactory.CreatePackageViewModel(packageItemDataSource, _packageService.IsExperienceEditor);

            if (viewModel == null)
                return _mediatorService.GetMediatorResponse<PackagesViewModel>(MediatorCodes.PackageSearchResponse.ViewModelError);

            return _mediatorService.GetMediatorResponse(MediatorCodes.PackageSearchResponse.Ok, viewModel);
        }
    }
}
