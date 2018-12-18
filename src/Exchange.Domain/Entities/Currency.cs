using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public class Currency
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Code { get; protected set; }
        public int Unit { get; protected set; }
        public virtual ICollection<CurrencyValue> Values { get; protected set; }
    }
}
