using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;

namespace CarRent.ReservationManagement.Domain
{
    public enum ReservationStatus
    {
        Reserviert,
        Vermietet
    }

    public class Reservation : IEntity<Guid>
    {
        public Guid id { get; set; }
        [Required]
        public DateTime start { get; set; }
        [Required]
        public DateTime end { get; set; }

        [NotMapped]
        public int days
        {
            get
            {
                if (start < end)
                {
                    var res = end - start;
                    return res.Days;
                }
                return 0;
            }
        }

        public ReservationStatus status { get; set; }
        [Required]
        public Guid CustomerId { get; set; }
        public Customer customer { get; set; }
        [Required]
        public Guid CarId { get; set; }
        public Car car { get; set; }
    }
}
