using System.Collections.Generic;
using Monolith.Team1.Entities;

namespace Monolith.Team1.Shared {
    public interface IsPlanetProvider {
        IEnumerable<Planet> Get();
    }
}