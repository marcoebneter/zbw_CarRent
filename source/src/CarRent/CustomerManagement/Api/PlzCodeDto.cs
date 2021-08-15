using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CustomerManagement.Api
{
    public class PlzCodeDto
    {
        public Guid id { get; set; }
        public string plz { get; set; }
        public string country { get; set; }
        public string city { get; set; }
    }
}
