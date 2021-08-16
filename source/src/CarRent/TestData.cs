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

            #region Plz
            plz.Add(new Plz() {city = "Appenzell", country = "Switzerland", plz = "9050", id = Guid.NewGuid()});
            #endregion

            foreach (Plz entity in plz)
            {
                modelBuilder.Entity<Plz>().HasData(entity);
            }
        }
    }
}
