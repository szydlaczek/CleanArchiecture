using Exchange.Domain.Entities;
using Exchange.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exchange.Infrastructure.Identity
{
    public abstract class Store<T>
       where T : CoreEntity
    {
        protected readonly ExchangeDbContext _context;

        public Store(ExchangeDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T Get(string id)
            => _context.Set<T>().FirstOrDefault(e => e.Id == id);

        public IEnumerable<T> Find(Func<T, bool> pred)
            => _context.Set<T>().Where(pred);
    }
}

