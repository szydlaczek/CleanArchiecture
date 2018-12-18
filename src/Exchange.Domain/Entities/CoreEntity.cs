using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Domain.Entities
{
    public abstract class CoreEntity
    {
        public string Id { get; private set; }
        public DateTime CreatedDate { get; }
        public DateTime? DeletedDate { get; private set; }
        protected CoreEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreatedDate = DateTime.Now;
        }
        public void Delete()
        {
            if (DeletedDate.HasValue)
                return;

            DeletedDate = DateTime.Now;
        }
    }
}
