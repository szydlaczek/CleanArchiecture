using Exchange.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Persistence
{
    public class ExchangeDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyValue> CurrencyValues { get; set; }
        public DbSet<SystemWallet> SystemWallet { get; set; }
        public DbSet<SystemWalletCurrency> SystemWalletCurrencies { get; set; }
        public DbSet<UserWallet> UserWallets { get; set; }
        public DbSet<UserWalletCurrency> UserWalletCurrencies { get; set; }
        public ExchangeDbContext(DbContextOptions<ExchangeDbContext> options)
            : base(options)
        {

        }
    }
}
