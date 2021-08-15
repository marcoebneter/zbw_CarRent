using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    public interface IPlzService
    {
        List<Plz> GetAll();
        List<Plz> GetById(Guid id);
        void Add(Plz entity);
        void Update(Plz entity);
        void Remove(Plz entity);
        void RemoveById(Guid id);
    }
}
