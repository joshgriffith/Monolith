using System;
using Monolith.Team2.Shared;

namespace Monolith.Team2.Entities {
    public class Person : IsPerson {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlanetName { get; set; }

        public Person() {
        }

        public Person(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}