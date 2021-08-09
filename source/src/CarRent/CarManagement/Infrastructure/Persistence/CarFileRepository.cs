using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Api;
using CarRent.CarManagement.Domain;

namespace CarRent.CarManagement.Infrastructure.Persistence
{
    public class CarFileRepository : ICarRepository
    {
        public CarFileRepository()
        {

        }

        public CarDto Add(CarDto car)
        {
            throw new NotImplementedException();
        }

        public void Update(CarDto car)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public CarDto GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
