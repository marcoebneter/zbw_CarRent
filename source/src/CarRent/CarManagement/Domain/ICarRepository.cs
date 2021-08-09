using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Api;

namespace CarRent.CarManagement.Domain
{
    public interface ICarRepository
    {
        CarDto Add(CarDto car);
        void Update(CarDto car);
        void RemoveById(int id);
        CarDto GetById(int id);
    }
}
