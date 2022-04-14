using System;
using Monolith.Team1.Shared;

namespace Monolith.Team1.Entities {
    public class Planet {
        public int Id { get; set; }
        public string Name { get; set; }

        public Planet() {
        }

        public Planet(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}