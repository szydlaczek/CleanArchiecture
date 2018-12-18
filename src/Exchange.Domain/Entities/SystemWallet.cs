using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public class SystemWallet
    {
        public int Id { get; protected set; }

        
        public decimal AmountPLN { get; protected set; }

        public virtual ICollection<SystemWalletCurrency> AvailableCurrencies { get; protected set; }
    }
}
