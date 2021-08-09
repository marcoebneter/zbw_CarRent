using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Api;

namespace CarRent.ReservationManagement.Api
{
    public class ReservationDto
    {
        public int id { get; set; }
        public CarDto car { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int price { get; set; }
    }
}
