using KATSU.Feature.Package.Models;
using KATSU.Feature.Package.ViewModels;

namespace KATSU.Feature.Package.Factories
{
    public interface IPackageViewModelFactory
    {
        PackageViewModel CreatePackageViewModel(IPackage packageDataSource, bool isExperienceEditor);
    }
}
