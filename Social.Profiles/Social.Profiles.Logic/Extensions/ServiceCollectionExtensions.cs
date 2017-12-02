using Microsoft.Extensions.DependencyInjection;
using Social.Profiles.Logic.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Profiles.Logic.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddProfileServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProfileService, ProfileService>();

            return serviceCollection;
        }
    }
}
