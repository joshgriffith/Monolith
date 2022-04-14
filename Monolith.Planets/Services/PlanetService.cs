using System;
using System.Collections.Generic;
using Monolith.Planets.Shared;

namespace Monolith.Planets.Services {
    public class PlanetService : IsPlanetProvider {

        public IEnumerable<Planet> Get() {
            return new List<Planet> {
                new(1, "Earth"),
                new(2, "Mars")
            };
        }
    }
}