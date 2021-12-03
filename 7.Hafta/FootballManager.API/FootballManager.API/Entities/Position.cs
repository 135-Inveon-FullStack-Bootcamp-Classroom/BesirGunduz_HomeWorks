using System.Collections.Generic;

namespace FootballManager.API.Entities
{
    public class Position : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Footballer> Footballers { get; set; }
    }
}
