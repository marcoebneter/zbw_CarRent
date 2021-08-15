using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Infrastructure.Context;
using CarRent.Common.Interfaces;
using CarRent.ReservationManagement.Domain;

namespace CarRent.ReservationManagement.Infrastructure.Persistence
{
    public class ReservationRepository : IRepository<Reservation, Guid>
    {
        private readonly CarRentDbContext _dbContext;

        public ReservationRepository(CarRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Reservation> GetAll()
        {
            return _dbContext.Reservations.Include(x => x.car).Include(x => x.customer).ToList();
        }

        public List<Reservation> FindById(Guid id)
        {
            return _dbContext.Reservations.Include(x => x.car).Include(x => x.customer).Where(x => x.id.Equals(id))
                .ToList();
        }

        public void Insert(Reservation entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Reservation entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(Reservation entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Remove(FindById(id).FirstOrDefault());
        }
    }
}
