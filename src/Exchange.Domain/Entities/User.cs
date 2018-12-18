using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public class User : CoreEntity
    {
        
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual UserWallet Wallet { get; set; }
    }
}
