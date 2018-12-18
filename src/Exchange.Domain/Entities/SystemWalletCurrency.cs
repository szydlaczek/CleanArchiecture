using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public class SystemWalletCurrency
    {
        public int Id { get; protected set; }
        public int Ammount { get; protected set; }
        
        public int CurrencyId { get; protected set; }

        public virtual Currency Currency { get; protected set; }

        
        public int SystemWalletId { get; protected set; }

        public virtual SystemWallet SystemWallet { get; protected set; }
    }
}
