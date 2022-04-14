using System.Collections.Generic;

namespace Monolith.Planets.Shared {
    public interface IsPlanetProvider {
        IEnumerable<Planet> Get();
    }
}