using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Profiles.Data.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddProfileContext(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<ProfileContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            return serviceCollection;
        }
    }
}
