using System.Collections.Generic;
using Monolith.Persons.Entities;
using Monolith.Persons.Shared;

namespace Monolith.Persons.Services {
    public class PersonService : IsPersonProvider {

        public IEnumerable<IsPerson> Get() {
            return new List<Person> {
                new(1, "Luke Skywalker"),
                new(2, "Han Solo")
            };
        }
    }
}