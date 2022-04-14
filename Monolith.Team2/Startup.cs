using System;
using Microsoft.Extensions.DependencyInjection;
using Monolith.Team2.Services;
using Monolith.Team2.Shared;

namespace Monolith.Team2 {
    public static class Startup {
        public static void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<IsPersonProvider, PersonService>();
        }
    }
}