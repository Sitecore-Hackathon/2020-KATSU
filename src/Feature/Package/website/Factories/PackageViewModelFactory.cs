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

        public PackagesViewModel CreatePackageViewModel(IEnumerable<PackageSearchResultItem> packages, bool isExperienceEditor)
        {
            return new PackagesViewModel
            {
                Packages = packages.Select(x=> new PackageViewModel {
                    PackageId = x.ItemId.ToString(),
                    PackageTitle= x.PackageName,
                    PackageSummary = x.Summary
                }),
                IsExperienceEditor = isExperienceEditor
            };
        }
    }
}
