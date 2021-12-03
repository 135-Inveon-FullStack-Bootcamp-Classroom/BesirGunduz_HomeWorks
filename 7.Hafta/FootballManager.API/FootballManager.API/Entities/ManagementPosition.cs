using System.Collections.Generic;

namespace FootballManager.API.Entities
{
    public class ManagementPosition : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
    }
}
