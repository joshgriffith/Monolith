using System;
using Microsoft.Extensions.DependencyInjection;
using Monolith.Planets.Services;
using Monolith.Planets.Shared;

namespace Monolith.Planets {
    public static class Startup {
        public static void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<IsPlanetProvider, PlanetService>();
        }
    }
}