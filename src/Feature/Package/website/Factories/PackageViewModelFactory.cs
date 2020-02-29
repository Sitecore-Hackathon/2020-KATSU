using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc;
using KATSU.Feature.Package.Models;
using KATSU.Feature.Package.ViewModels;

namespace KATSU.Feature.Package.Factories
{
    public class PackageViewModelFactory : IPackageViewModelFactory
    {
     private readonly IGlassHtml _glassHtml;

        public PackageViewModelFactory(IGlassHtml glassHtml)
        {
            _glassHtml = glassHtml;
        }
        
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
        
          public PackagesViewModel CreatePackageViewModel(IEnumerable<PackageSearchResultItem> packages, bool isExperienceEditor)
        {
            return new PackagesViewModel
            {
                Packages = packages.Select(x=> new PackageViewModel {
                    PackageId = x.ItemId.ToString(),
                    PackageTitle= x.PackageName,
                    PackageSummary = x.Summary
                }),
                IsExperienceEditor = isExperienceEditor,
                TotalResults = packages.Count()
            };
        }
    }
}
