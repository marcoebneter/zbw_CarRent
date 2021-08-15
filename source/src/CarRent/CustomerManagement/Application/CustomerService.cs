using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer, Guid> _repository;

        public CustomerService(IRepository<Customer, Guid> repository)
        {
            _repository = repository;
        }

        public List<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Customer> GetById(Guid id)
        {
            return _repository.FindById(id);
        }

        public void Add(Customer entity)
        {
            _repository.Insert(entity);
        }

        public void Update(Customer entity)
        {
            _repository.Update(entity);
        }

        public void Remove(Customer entity)
        {
            _repository.Remove(entity);
        }

        public void RemoveById(Guid id)
        {
            _repository.Remove(id);
        }
    }
}
