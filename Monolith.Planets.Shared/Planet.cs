namespace Monolith.Planets.Shared {
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