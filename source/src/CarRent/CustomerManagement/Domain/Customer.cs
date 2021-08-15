using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;

namespace CarRent.CustomerManagement.Domain
{
    public class Customer : IEntity<Guid>
    {
        public Guid id { get; set; }
        [Required]
        public string firstname { get; set; }
        [Required]
        public string lastname { get; set; }
        [Required]
        public string street { get; set; }
        [Required]
        public Guid plzId { get; set; }
        public Plz plz { get; set; }
    }
}
