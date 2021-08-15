using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CarManagement.Api
{
    public class ClassDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public decimal dailyFee { get; set; }
    }
}
