using System.Collections.Generic;
using Monolith.Team2.Entities;
using Monolith.Team2.Shared;

namespace Monolith.Team2.Services {
    public class PersonService : IsPersonProvider {

        public IEnumerable<IsPerson> Get() {
            return new List<Person> {
                new(1, "Luke Skywalker"),
                new(2, "Han Solo")
            };
        }
    }
}