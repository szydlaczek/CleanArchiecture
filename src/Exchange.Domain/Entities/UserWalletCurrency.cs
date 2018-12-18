using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public class UserWalletCurrency
    {
        public int Id { get; set; }
        
        public string UserWalletId { get; set; }

        public virtual UserWallet UserWallet { get;  set; }
        
        public int CurrencyId { get; protected set; }

        public virtual Currency Currency { get;  set; }
        public int Quantity { get;  set; }

        protected UserWalletCurrency()
        {

        }
    }
}
