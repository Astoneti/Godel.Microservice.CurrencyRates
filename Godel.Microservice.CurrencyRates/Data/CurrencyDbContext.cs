using Godel.Microservice.CurrencyRates.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Godel.Microservice.CurrencyRates.Data
{
    public class CurrencyDbContext : DbContext
    {
        public DbSet<CurrencyEntity> Currencies { get; set; }

        public CurrencyDbContext(DbContextOptions<CurrencyDbContext> options)
         : base(options)
        {
        }
    }
}
