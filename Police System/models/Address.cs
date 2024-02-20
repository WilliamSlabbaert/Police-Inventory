﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police_System.models
{
    public class Address
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }

        public string City { get; set; }
        public string ZipCode { get; set; }

        public string State { get; set; }
        public string Country { get; set; }
    }
}
