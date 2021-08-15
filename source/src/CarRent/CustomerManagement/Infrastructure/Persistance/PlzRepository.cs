using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Infrastructure.Context;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Infrastructure.Persistance
{
    public class PlzRepository : IRepository<Plz, Guid>
    {
        private readonly CarRentDbContext _dbContext;

        public PlzRepository(CarRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Plz> GetAll()
        {
            return _dbContext.Plzs.ToList();
        }

        public List<Plz> FindById(Guid id)
        {
            return _dbContext.Plzs.Where(x => x.id.Equals(id)).ToList();
        }

        public void Insert(Plz entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Plz entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(Plz entity)
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
