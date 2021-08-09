using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace CarRent.CustomerManagement.Api
{
    public class AddressDto
    {
        public int id { get; set; }
        public string street { get; set; }
        public int nr { get; set; }
        public int plz { get; set; }
        public string city { get; set; }
    }
}
