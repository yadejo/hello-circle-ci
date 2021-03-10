using System;
using Microsoft.Extensions.DependencyInjection;
using MovApi.Domain.Handlers;
using MovApi.Domain.DataAccess;
using MovApi.Infrastructure.DataAccess;
using System.Collections.Generic;
namespace MovApi.Host.Ioc {
    public static class IocConfiguration {
        public static void RegisterDependencies(this IServiceCollection services) {
            services.AddScoped<IGetMoviesRepository, InMemoryGetMoviesRepository>();
        }
    }
}