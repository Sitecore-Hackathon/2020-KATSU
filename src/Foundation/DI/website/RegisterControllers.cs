using KATSU.Foundation.DI.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace KATSU.Foundation.DI
{
    public class RegisterControllers : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers(
                "KATSU.Feature.*");
        }
    }
}
