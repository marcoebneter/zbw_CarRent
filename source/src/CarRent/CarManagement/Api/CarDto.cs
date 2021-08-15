using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CarManagement.Api
{
    public class CarDto
    {
        public Guid id { get; set; }
        public Guid carClassId { get; set; }
        public string carBrand { get; set; }
        public string carType { get; set; }
        public string carClass { get; set; }
        public decimal carPriceDay { get; set; }
    }
}
