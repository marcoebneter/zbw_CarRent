using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CustomerManagement.Api
{
    public class CustomerDto
    {
        public Guid id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string street { get; set; }
        public Guid plzId { get; set; }
        public string plz { get; set; }
        public string country { get; set; }
        public string city { get; set; }
    }
}
