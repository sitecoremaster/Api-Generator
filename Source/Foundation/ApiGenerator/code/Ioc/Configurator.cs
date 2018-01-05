using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using SitecoreMaster.Foundation.ApiGenerator.Repository;
using SitecoreMaster.Foundation.ApiGenerator.Repository.Interfaces;
using SitecoreMaster.Foundation.ApiGenerator.Services;
using SitecoreMaster.Foundation.ApiGenerator.Services.Interfaces;

namespace SitecoreMaster.Foundation.ApiGenerator.Ioc
{
    public class Configurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            // Repository
            serviceCollection.AddTransient<IDefinitionRepository, DefinitionRepository>();
            serviceCollection.AddTransient<IPathRepository, PathRepository>();

            // Services
            serviceCollection.AddTransient<IDefinitionService, DefinitionService>();
            serviceCollection.AddTransient<IPathService, PathService>();
        }
    }
}