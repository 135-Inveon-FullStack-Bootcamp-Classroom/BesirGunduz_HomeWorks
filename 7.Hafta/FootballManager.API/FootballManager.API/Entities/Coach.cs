using System;
using System.Collections.Generic;

namespace FootballManager.API.Entities
{
    public class Coach : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual Team Team { get; set; }
        public virtual NationalTeam NationalTeam { get; set; }
        public virtual ICollection<Tactic> Tactics { get; set; }
    }
}
