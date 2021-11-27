using System.Collections.Generic;

namespace MovieStore.API.Entities
{
    public class Genre : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GenreMovie> GenreMovie { get; set; }
    }
}
