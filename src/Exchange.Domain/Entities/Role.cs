using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public class Role : CoreEntity
    {
        
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public Role()
        {
            Users = new HashSet<User>();
        }
    }
}
