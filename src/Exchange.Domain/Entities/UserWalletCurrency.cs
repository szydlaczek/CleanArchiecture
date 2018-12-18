using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public class UserWalletCurrency
    {
        public int Id { get; protected set; }
        
        public string UserWalletId { get; protected set; }

        public virtual UserWallet UserWallet { get; protected set; }

        
        public int CurrencyId { get; protected set; }

        public virtual Currency Currency { get; protected set; }
        public int Quantity { get; protected set; }

        protected UserWalletCurrency()
        {

        }
    }
}
