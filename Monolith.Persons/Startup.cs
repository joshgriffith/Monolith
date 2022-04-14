using System;
using Microsoft.Extensions.DependencyInjection;
using Monolith.Persons.Services;
using Monolith.Persons.Shared;

namespace Monolith.Persons {
    public static class Startup {
        public static void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<IsPersonProvider, PersonService>();
        }
    }
}