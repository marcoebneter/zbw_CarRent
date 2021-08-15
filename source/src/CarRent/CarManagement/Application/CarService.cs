using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Api;
using CarRent.CarManagement.Domain;
using CarRent.Common.Interfaces;

namespace CarRent.CarManagement.Application
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car, Guid> _carRepository;

        public CarService(IRepository<Car, Guid> carRepository)
        {
            _carRepository = carRepository;
        }

        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public List<Car> GetById(Guid id)
        {
            return _carRepository.FindById(id);
        }

        public List<Car> GetByType(CarClassTypes type)
        {
            return _carRepository.GetAll().Where(x => x.carClass.carClassType == type).ToList();
        }

        public void Add(Car car)
        {
            _carRepository.Insert(car);
        }

        public void DeleteById(Guid id)
        {
            _carRepository.Remove(id);
        }

        public void Delete(Car car)
        {
            _carRepository.Remove(car);
        }

        public void Update(Car car)
        {
            _carRepository.Update(car);
        }
    }
}