using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.ReservationManagement.Api
{
    public class ContractDto
    {
        public int id { get; set; }
        public ReservationDto reservation { get; set; }
    }
}
