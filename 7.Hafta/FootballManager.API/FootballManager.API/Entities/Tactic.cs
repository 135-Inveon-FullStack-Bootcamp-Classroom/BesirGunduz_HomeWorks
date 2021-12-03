namespace FootballManager.API.Entities
{
    public class Tactic : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CoachId { get; set; }
        public virtual Coach Coach { get; set; }
    }
}
