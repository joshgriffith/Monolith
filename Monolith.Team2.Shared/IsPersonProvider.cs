using System.Collections.Generic;

namespace Monolith.Team2.Shared {
    public interface IsPersonProvider {
        IEnumerable<IsPerson> Get();
    }
}