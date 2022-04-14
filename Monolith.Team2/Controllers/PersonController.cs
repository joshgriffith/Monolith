using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Monolith.Team1.Shared;
using Monolith.Team2.Shared;

namespace Monolith.Team2.Controllers {

    [Route("persons")]
    public class PersonController : ControllerBase {
        private readonly IsPersonProvider _people;
        private readonly IsPlanetProvider _planets;

        public PersonController(IsPersonProvider people, IsPlanetProvider planets) {
            _people = people;
            _planets = planets;
        }

        public IEnumerable<IsPerson> Get() {
            var planets = _planets.Get().ToList();
            var people = _people.Get();

            foreach (var person in people) {
                var planet = planets[new Random().Next(planets.Count)];
                person.PlanetName = planet.Name;
            }

            return people;
        }
    }
}