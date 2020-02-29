using KATSU.Feature.Package.Models;
using KATSU.Feature.Package.ViewModels;
using System.Collections.Generic;

namespace KATSU.Feature.Package.Factories
{
    public interface IPackageViewModelFactory
    {
        PackagesViewModel CreatePackageViewModel(IEnumerable<PackageSearchResultItem> packages, bool isExperienceEditor);
        PackageViewModel CreatePackageViewModel(IPackage packageDataSource, bool isExperienceEditor);
    }
}
