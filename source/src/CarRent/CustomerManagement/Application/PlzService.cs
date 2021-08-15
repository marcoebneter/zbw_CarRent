using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    public class PlzService : IPlzService
    {
        private readonly IRepository<Plz, Guid> _repository;

        public PlzService(IRepository<Plz, Guid> repository)
        {
            _repository = repository;
        }

        public List<Plz> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Plz> GetById(Guid id)
        {
            return _repository.FindById(id);
        }

        public void Add(Plz entity)
        {
            _repository.Insert(entity);
        }

        public void Update(Plz entity)
        {
            _repository.Update(entity);
        }

        public void Remove(Plz entity)
        {
            _repository.Remove(entity);
        }

        public void RemoveById(Guid id)
        {
            _repository.Remove(id);
        }
    }
}
