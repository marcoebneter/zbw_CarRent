using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;

namespace CarRent.CarManagement.Application
{
    public interface IClassService
    {
        List<Class> GetAll();
        List<Class> GetById(Guid id);
        void Add(Class car);
        void DeleteById(Guid id);
        void Delete(Class car);
        void Update(Class car);
    }
}
