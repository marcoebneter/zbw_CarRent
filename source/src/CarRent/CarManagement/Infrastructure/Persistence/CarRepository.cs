using System;
using System.Collections.Generic;
using System.Linq;
using CarRent.CarManagement.Domain;
using CarRent.Common.Infrastructure.Context;
using CarRent.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarRent.CarManagement.Infrastructure.Persistence
{
    public class CarRepository : IRepository<Car, Guid>
    {
        private readonly CarRentDbContext _dbContext;

        public CarRepository(CarRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Car> GetAll()
        {
            return _dbContext.Cars.Include(x => x.carClass).ToList();
        }

        public List<Car> FindById(Guid id)
        {
            return _dbContext.Cars.Include(x => x.carClass).Where(x => x.carClassId.Equals(id)).ToList();
        }

        public void Insert(Car entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Car entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(Car entity)
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
