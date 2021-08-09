﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CarManagement.Api
{
    public class CarDto
    {
        public int id { get; set; }
        public ClassDto carClass { get; set; }
        public BrandDto carBrand { get; set; }
        public TypeDto carType { get; set; }
    }
}
