using CarRent.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Common.Infrastructure.Context
{
    public class BaseDbContext : DbContext
    {
        protected BaseDbContext()
        {

        }

        protected BaseDbContext(DbContextOptions<CarRentDbContext> options) : base(options)
        {

        }

        protected static void ConfigureModelBinding<TO, TI>(ModelBuilder modelBuilder) where TO : class
        {
            SetPrimaryKeys<TO, TI>(modelBuilder);
        }

        private static void SetPrimaryKeys<TO, TI>(ModelBuilder modelBuilder) where TO : class
        {
            if (typeof(IEntity<TI>).IsAssignableFrom(typeof(TO)))
            {
                modelBuilder.Entity<TO>().HasKey(c => ((IEntity<TI>) c).id);
            }
        }
    }
}
