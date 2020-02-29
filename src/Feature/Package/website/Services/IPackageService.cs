using KATSU.Feature.Package.Models;

namespace KATSU.Feature.Package.Services
{
    public interface IPackageService
    {
        IPackage GetPackage(string packageId);
        bool IsExperienceEditor { get; }
    }
}
