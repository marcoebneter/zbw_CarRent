using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Infrastructure.Context;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Infrastructure.Persistance
{
    public class CustomerRepository : IRepository<Customer, Guid>
    {
        private readonly CarRentDbContext _dbContext;

        public CustomerRepository(CarRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Customer> GetAll()
        {
            return _dbContext.Customers.ToList();
        }

        public List<Customer> FindById(Guid id)
        {
            return _dbContext.Customers.Where(x => x.id.Equals(x)).ToList();
        }

        public void Insert(Customer entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Customer entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(Customer entity)
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
