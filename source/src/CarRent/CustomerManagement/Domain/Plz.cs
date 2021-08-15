using System;
using System.ComponentModel.DataAnnotations;
using CarRent.Common.Interfaces;

namespace CarRent.CustomerManagement.Domain
{
    public class Plz : IEntity<Guid>
    {
        public Guid id { get; set; }
        [Required]
        public string plz { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string city { get; set; }
    }
}
