using System;
using System.Collections.Generic;

namespace OopApp.Entities
{
    public class User : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public UserRole UserRole { get; set; }
        public virtual ICollection<City> Cities { get; set; }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Saçmalama dostum, yaş sıfırdan küçük olamaz!");
                }

                age = value;
            }
        }
    }
}
