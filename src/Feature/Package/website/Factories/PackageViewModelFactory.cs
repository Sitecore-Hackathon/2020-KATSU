using KATSU.Feature.Package.Models;
using KATSU.Feature.Package.ViewModels;

namespace KATSU.Feature.Package.Factories
{
    public class PackageViewModelFactory : IPackageViewModelFactory
    {
        public PackageViewModel CreatePackageViewModel(IPackage packageDataSource, bool isExperienceEditor)
        {
            if (packageDataSource == null)
                return new PackageViewModel();

            return new PackageViewModel
            {
                Id = packageDataSource.Id.ToString(),
                PackageName = packageDataSource.PackageName,
                PackageIdentifier = packageDataSource.PackageIdentifier,
                PackageFile = packageDataSource.PackageFile,
                Documentation = packageDataSource.Documentation,
                IsExperienceEditor = isExperienceEditor
            };
        }
    }
}