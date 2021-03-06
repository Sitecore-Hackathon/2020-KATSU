using KATSU.Feature.Package.Models;
using KATSU.Foundation.Search.Models;
using System.Collections.Generic;

namespace KATSU.Feature.Package.Services
{
    public interface IPackageService
    {
        IPackage GetPackage(string packageId);
        IEnumerable<PackageSearchResultItem> GetPackagesSearch(string query);
        bool IsExperienceEditor { get; }
    }
}
