using System;
using Microsoft.Extensions.DependencyInjection;
using Monolith.Team1.Services;
using Monolith.Team1.Shared;

namespace Monolith.Team1 {
    public static class Startup {
        public static void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<IsPlanetProvider, PlanetService>();
        }
    }
}