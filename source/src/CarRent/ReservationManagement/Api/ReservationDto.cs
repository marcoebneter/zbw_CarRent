using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Api;

namespace CarRent.ReservationManagement.Api
{
    public class ReservationDto
    {
        public Guid id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int totalDays { get; set; }
        public string status { get; set; }
        public Guid customerId { get; set; }
        public string customer { get; set; }
        public Guid carId { get; set; }
        public string car { get; set; }
        public decimal price { get; set; }
    }
}
