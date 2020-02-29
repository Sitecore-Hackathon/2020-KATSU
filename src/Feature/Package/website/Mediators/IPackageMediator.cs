using KATSU.Feature.Package.ViewModels;
using KATSU.Foundation.Core.Models;

namespace KATSU.Feature.Package.Mediators
{
    public interface IPackageMediator
    {
        MediatorResponse<PackagesViewModel> RequestPackageViewModel(string query);
    }
}
