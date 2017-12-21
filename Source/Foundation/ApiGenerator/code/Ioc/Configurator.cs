using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using SitecoreMaster.Foundation.ApiGenerator.Repository.Interfaces;
using SitecoreMaster.Foundation.ApiGenerator.Repository;

namespace SitecoreMaster.Foundation.ApiGenerator.Ioc
{
    public class Configurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddTransient<
        }
    }
}