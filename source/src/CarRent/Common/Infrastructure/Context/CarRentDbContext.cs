using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;
using CarRent.CustomerManagement.Domain;
using CarRent.ReservationManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Common.Infrastructure.Context
{
    public class CarRentDbContext : BaseDbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Plz> Plzs { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureModelBinding<Car, Guid>(modelBuilder);
            ConfigureModelBinding<Class, Guid>(modelBuilder);
            ConfigureModelBinding<Customer, Guid>(modelBuilder);
            ConfigureModelBinding<Plz, Guid>(modelBuilder);
            ConfigureModelBinding<Reservation, Guid>(modelBuilder);
        }
    }
}
