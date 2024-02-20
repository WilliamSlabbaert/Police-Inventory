﻿using System;
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

        public DateTime yearOfManufacture { get; set; }
        public string AmmoType { get; set; }
        public int MagazineClipSize { get; set; }
    }
}