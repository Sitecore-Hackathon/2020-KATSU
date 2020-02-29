using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using PSGN.Feature.PageContent.Mediators;
using PSGN.Feature.PageContent.Services;
using PSGN.Feature.PageContent.Factories;

namespace PSGN.Feature.PageContent.DI
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
