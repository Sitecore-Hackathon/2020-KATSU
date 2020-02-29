using KATSU.Feature.Package.ViewModels;
using KATSU.Foundation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KATSU.Feature.Package.Factories;
using KATSU.Feature.Package.Services;
using KATSU.Foundation.Core.Services;

namespace KATSU.Feature.Package.Mediators
{
    public class PackageMediator : IPackageMediator
    {
        private readonly IPackageService _packageService;
        private readonly IMediatorService _mediatorService;
        private readonly IPackageViewModelFactory _packageViewModelFactory;

        public PackageMediator(IPackageService packageService,
                               IMediatorService mediatorService,
                               IPackageViewModelFactory packageViewModelFactory)
        {
            _packageService = packageService;
            _mediatorService = mediatorService;
            _packageViewModelFactory = packageViewModelFactory;
        }

        public MediatorResponse<PackageViewModel> RequestPackageViewModel(string packageId)
        {
            var packageDataSource = _packageService.GetPackage(packageId);

            if (packageDataSource == null)
                return _mediatorService.GetMediatorResponse<PackageViewModel>(Constants.MediatorCodes.PackageResponse.DataSourceError);

            var viewModel =
                _packageViewModelFactory.CreatePackageViewModel(packageDataSource, _packageService.IsExperienceEditor);

            if (viewModel == null)
                return _mediatorService.GetMediatorResponse<PackageViewModel>(Constants.MediatorCodes.PackageResponse
                    .ViewModelError);

            return _mediatorService.GetMediatorResponse(Constants.MediatorCodes.PackageResponse.Ok, viewModel);
        }
    }
}
