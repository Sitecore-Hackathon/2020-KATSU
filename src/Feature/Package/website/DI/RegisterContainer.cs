using KATSU.Feature.Package.Factories;
using KATSU.Feature.Package.Mediators;
using KATSU.Feature.Package.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace KATSU.Feature.Package.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPackageMediator, PackageMediator>();
            serviceCollection.AddTransient<IPackageService, PackageService>();
            serviceCollection.AddTransient<IPackageViewModelFactory, PackageViewModelFactory>();
        }
    }
}
