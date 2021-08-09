using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace CarRent.CarManagement.Api
{
    public class TypeDto
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
