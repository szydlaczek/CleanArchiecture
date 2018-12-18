using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public class CurrencyValue
    {
        public int Id { get; protected set; }
        public double PurchasePrice { get; protected set; }
        public double SellPrice { get; protected set; }
        public double AveragePrice { get; protected set; }
        public DateTime PublicationDate { get; protected set; }        
        public int CurrencyId { get; protected set; }
        public virtual Currency Currency { get; protected set; }
    }
}
