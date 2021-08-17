using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRent
{
    public class TestData
    {
        public TestData(ModelBuilder modelBuilder)
        {
            var plz = new List<Plz>();
            var cus = new List<Customer>();

            #region Plz
            plz.Add(new Plz() {city = "Appenzell", country = "Switzerland", plz = "9050", id = Guid.NewGuid()});
            plz.Add(new Plz() {city = "Gossau", country = "Switzerland", plz = "9200", id = Guid.NewGuid()});
            plz.Add(new Plz() { city = "Zürich", country = "Switzerland", plz = "8001", id = Guid.NewGuid() });
            plz.Add(new Plz() { city = "Bern", country = "Switzerland", plz = "3001", id = Guid.NewGuid() });
            plz.Add(new Plz() { city = "Basel", country = "Switzerland", plz = "4001", id = Guid.NewGuid() });
            plz.Add(new Plz() { city = "Uri", country = "Switzerland", plz = "6460", id = Guid.NewGuid() });
            #endregion

            #region Customer

            #endregion

            foreach (Plz entity in plz)
            {
                modelBuilder.Entity<Plz>().HasData(entity);
            }
        }
    }
}
