using System;
using Microsoft.Extensions.DependencyInjection;
using Movies.Domain.Handlers;
using Movies.Domain.DataAccess;
using Movies.Infrastructure.DataAccess;
using System.Collections.Generic;
namespace Movies.Host.Ioc {
    public static class IocConfiguration {
        public static void RegisterDependencies(this IServiceCollection services) {
            services.AddScoped<IGetMoviesRepository, InMemoryGetMoviesRepository>();
        }
    }
}