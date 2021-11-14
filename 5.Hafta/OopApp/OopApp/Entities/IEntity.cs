using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp.Entities
{
    // tablolarda zorunlu olarak eklenecek alan
    public interface IEntity
    {
        public int Id { get; set; }
    }
}
