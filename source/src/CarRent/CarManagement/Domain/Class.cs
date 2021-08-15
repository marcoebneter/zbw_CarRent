using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;

namespace CarRent.CarManagement.Domain
{
    public enum CarClassTypes
    {
        Einfachklasse,
        Mittelklasse,
        Luxusklasse
    }

    public class Class : IEntity<Guid>
    {
        public Guid id { get; set; }
        [Required]
        public CarClassTypes carClassType { get; set; }
        [Required]
        public decimal dailyFee { get; set; }
    }
}
