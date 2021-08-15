using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.ReservationManagement.Domain;

namespace CarRent.ReservationManagement.Application
{
    public class ReservationService : IReservationService
    {
        private readonly IRepository<Reservation, Guid> _repository;

        public ReservationService(IRepository<Reservation, Guid> repository)
        {
            _repository = repository;
        }

        public List<Reservation> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Reservation> GetById(Guid id)
        {
            return _repository.FindById(id);
        }

        public void Add(Reservation entity)
        {
            _repository.Insert(entity);
        }

        public void Update(Reservation entity)
        {
            _repository.Update(entity);
        }

        public void Remove(Reservation entity)
        {
            _repository.Remove(entity);
        }

        public void RemoveById(Guid id)
        {
            _repository.Remove(id);
        }
    }
}
