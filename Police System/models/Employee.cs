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

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth { 
            get 
            { 
                return _dateOfBirth; 
            }
            set 
            {
                _dateOfBirth = value;
                CurrentAge = DateTime.Today.Year - value.Year;
            } 
        }
        public int CurrentAge { get; private set; }

        public Address Address { get; set; }
        public string BadgeNumber { get; set; }
        public string Role { get; set; }
        private Weapon _currentWeapon;
        public Weapon CurrentWeapon { 
            get 
            { 
                return _currentWeapon; 
            } 
            set 
            { 
                value.IsOccupied = true;
                _currentWeapon = value; 
            } 
        }
        private Vehicle _currentVehicle;
        public Vehicle CurrentVehicle
        {
            get
            {
                return _currentVehicle;
            }
            set
            {
                value.IsOccupied = true;
                _currentVehicle = value;
            }
        }
    }
}
