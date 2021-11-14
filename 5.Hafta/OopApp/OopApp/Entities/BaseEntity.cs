using System;

namespace OopApp.Entities
{
    // bütün tablolara miras olarak verilecek alanlar
    public class BaseEntity
    {
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
