using Police_System.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police_System.models
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public DateTime YearOfManufacture { get; set; }
        public FuelType FuelType { get; set; }

        public int AmountOfDistance { get; set; }
        public int LicensePlate { get; set; }

        public bool IsOccupied { get; set; }
    }
}
