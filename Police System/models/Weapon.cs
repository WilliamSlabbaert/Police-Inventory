using Police_System.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police_System.models
{
    public class Weapon
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string SerialNumber { get; set; }
        public DateTime YearOfManufacture { get; set; }
        public AmmoType AmmoType { get; set; }
        public int MagazineClipSize { get; set; }
    }
}
