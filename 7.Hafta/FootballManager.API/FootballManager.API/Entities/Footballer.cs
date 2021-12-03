using System;

namespace FootballManager.API.Entities
{
    public class Footballer : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public int? NationalTeamId { get; set; }
        public virtual NationalTeam NationalTeam { get; set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

    }
}
