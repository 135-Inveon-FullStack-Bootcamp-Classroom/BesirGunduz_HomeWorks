using System.Collections.Generic;

namespace FootballManager.API.Entities
{
    public class Team : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int CoachId { get; set; }
        public virtual Coach Coach { get; set; }
        public virtual ICollection<Footballer> Footballers { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }

    }
}
