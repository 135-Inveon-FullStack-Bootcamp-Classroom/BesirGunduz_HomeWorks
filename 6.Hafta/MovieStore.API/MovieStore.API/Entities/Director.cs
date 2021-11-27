using System.Collections.Generic;

namespace MovieStore.API.Entities
{
    public class Director : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Movie> Movies { get; set; }
    }
}