using System.Collections.Generic;

namespace OopApp.Entities
{
    public class City : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual User User { get; set; }

    }
}
