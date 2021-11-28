using System.Collections.Generic;

namespace MovieStore.API.Entities
{
    public class Movie : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int Budget { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
