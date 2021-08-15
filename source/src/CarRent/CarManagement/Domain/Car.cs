using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;

namespace CarRent.CarManagement.Domain
{
    public class Car : IEntity<Guid>
    {
        public Guid id { get; set; }
        [Required]
        public Guid carClassId { get; set; }
        public Class carClass { get; set; }
        [Required]
        public string brand { get; set; }
        [Required]
        public string type { get; set; }
    }
}
