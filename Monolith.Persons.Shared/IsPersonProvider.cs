using System.Collections.Generic;

namespace Monolith.Persons.Shared {
    public interface IsPersonProvider {
        IEnumerable<IsPerson> Get();
    }
}