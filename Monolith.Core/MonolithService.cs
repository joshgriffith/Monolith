using System;
using Microsoft.Extensions.DependencyInjection;

namespace Monolith.Core {
    public abstract class MonolithService {
        public abstract void ConfigureServices(IServiceCollection services);
    }
}