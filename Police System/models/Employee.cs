using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Police_System.models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Address Address { get; set; }
        public string BadgeNumber { get; set; }
        public string Role {  get; set; }

        public Weapon CurrentWeapon { get; set; }
        public Vehicle CurrentVehicle { get; set; }
    }
}
