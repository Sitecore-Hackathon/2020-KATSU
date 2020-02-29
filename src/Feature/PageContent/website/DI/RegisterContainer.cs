using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using KATSU.Feature.PageContent.Mediators;
using KATSU.Feature.PageContent.Services;
using KATSU.Feature.PageContent.Factories;

namespace KATSU.Feature.PageContent.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPageContentMediator, PageContentMediator>();
            serviceCollection.AddTransient<IPageContentService, PageContentService>();
            serviceCollection.AddTransient<IPageContentViewModelFactory, PageContentViewModelFactory>();
        }
    }
}
