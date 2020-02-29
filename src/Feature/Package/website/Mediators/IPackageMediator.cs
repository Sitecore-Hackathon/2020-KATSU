using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KATSU.Feature.Package.ViewModels;
using KATSU.Foundation.Core.Models;

namespace KATSU.Feature.Package.Mediators
{
    public interface IPackageMediator
    {
        MediatorResponse<PackageViewModel> RequestPackageDetailsViewModel(string packageId);
        MediatorResponse<PackagesViewModel> RequestPackageViewModel(string query);
    }
}
