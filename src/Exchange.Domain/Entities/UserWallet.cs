using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public class UserWallet
    {
        public string UserId { get; protected set; }

        public virtual User User { get; protected set; }
        public decimal AmountPLN { get; protected set; }
        public virtual ICollection<UserWalletCurrency> Currencies { get; protected set; }
    }
}
