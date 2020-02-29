using KATSU.Feature.Navigation.Factories;
using KATSU.Feature.Navigation.Mediators;
using KATSU.Feature.Navigation.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace KATSU.Feature.Navigation.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IHeaderMediator, HeaderMediator>();
            serviceCollection.AddTransient<IHeaderService, HeaderService>();
            serviceCollection.AddTransient<IHeaderViewModelFactory, HeaderViewModelFactory>();
            serviceCollection.AddTransient<INavMediator, NavMediator>();
            serviceCollection.AddTransient<INavService, NavService>();
            serviceCollection.AddTransient<INavViewModelFactory, NavViewModelFactory>();
        }
    }
}
