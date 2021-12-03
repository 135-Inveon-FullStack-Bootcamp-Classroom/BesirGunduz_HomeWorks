using System;

namespace FootballManager.API.Entities
{
    public class Manager : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public int ManagementPositionId { get; set; }
        public virtual ManagementPosition ManagementPosition { get; set; }
    }
}
