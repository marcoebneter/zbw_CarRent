using System;
using System.Collections.Generic;

namespace CarRent.CarManagement.Domain
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(Guid id);
        List<Car> GetByType(CarClassTypes type);
        void Add(Car car);
        void DeleteById(Guid id);
        void Delete(Car car);
        void Update(Car car);
    }
}
