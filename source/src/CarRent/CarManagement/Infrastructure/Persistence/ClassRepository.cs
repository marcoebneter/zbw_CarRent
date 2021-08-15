using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;
using CarRent.Common.Infrastructure.Context;
using CarRent.Common.Interfaces;

namespace CarRent.CarManagement.Infrastructure.Persistence
{
    public class ClassRepository : IRepository<Class, Guid>
    {
        private readonly CarRentDbContext _dbContext;

        public ClassRepository(CarRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Class> GetAll()
        {
            return _dbContext.Classes.ToList();
        }

        public List<Class> FindById(Guid id)
        {
            return _dbContext.Classes.Where(x => x.id.Equals(id)).ToList();
        }

        public void Insert(Class entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Class entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(Class entity)
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
