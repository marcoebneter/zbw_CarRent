using System;
using System.Collections.Generic;
using CarRent.CarManagement.Domain;
using CarRent.Common.Interfaces;

namespace CarRent.CarManagement.Application
{
    public class ClassService : IClassService
    {
        private readonly IRepository<Class, Guid> _repository;

        public ClassService(IRepository<Class, Guid> repository)
        {
            _repository = repository;
        }

        public List<Class> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Class> GetById(Guid id)
        {
            return _repository.FindById(id);
        }

        public void Add(Class car)
        {
            _repository.Insert(car);
        }

        public void DeleteById(Guid id)
        {
            _repository.Remove(id);
        }

        public void Delete(Class car)
        {
            _repository.Remove(car);
        }

        public void Update(Class car)
        {
            _repository.Update(car);
        }
    }
}
