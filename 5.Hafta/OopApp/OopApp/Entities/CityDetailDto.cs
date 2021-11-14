using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp.Entities
{
    public class CityDetailDto : BaseEntity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string UserName { get; set; }
        public UserRole UserRole { get; set; }
    }
}
