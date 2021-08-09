using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CustomerManagement.Api
{
    public class CustomerDto
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public AddressDto address { get; set; }
    }
}
