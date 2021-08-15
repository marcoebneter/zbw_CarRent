using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.ReservationManagement.Domain;

namespace CarRent.ReservationManagement.Application
{
    public interface IReservationService
    {
        List<Reservation> GetAll();
        List<Reservation> GetById(Guid id);
        void Add(Reservation entity);
        void Update(Reservation entity);
        void Remove(Reservation entity);
        void RemoveById(Guid id);
    }
}
