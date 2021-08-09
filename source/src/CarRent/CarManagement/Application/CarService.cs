using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;

namespace CarRent.CarManagement.Application
{
    public class CarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository _carRepository)
        {

        }
    }
}
