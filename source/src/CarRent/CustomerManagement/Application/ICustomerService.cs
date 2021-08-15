using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetById(Guid id);
        void Add(Customer entity);
        void Update(Customer entity);
        void Remove(Customer entity);
        void RemoveById(Guid id);
    }
}
