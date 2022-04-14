using System;
using System.Collections.Generic;
using Monolith.Team1.Entities;
using Monolith.Team1.Shared;

namespace Monolith.Team2.Services {
    public class DebugPlanetService : IsPlanetProvider {

        public IEnumerable<Planet> Get() {
            return new List<Planet> {
                new(1, "Test Planet 1"),
                new(2, "Test Planet 2")
            };
        }
    }
}