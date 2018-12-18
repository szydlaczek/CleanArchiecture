using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public class UserWallet
    {
        public string UserId { get; set; }

        public virtual User User { get; set; }
        public decimal AmountPLN { get; set; }
        public virtual ICollection<UserWalletCurrency> Currencies { get; set; }
    }
}
