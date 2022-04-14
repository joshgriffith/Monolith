using System;
using System.Collections.Generic;
using Monolith.Team1.Entities;
using Monolith.Team1.Shared;

namespace Monolith.Team1.Services {
    public class PlanetService : IsPlanetProvider {

        public IEnumerable<Planet> Get() {
            return new List<Planet> {
                new(1, "Earth"),
                new(2, "Mars")
            };
        }
    }
}