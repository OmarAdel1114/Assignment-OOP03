using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP01
{
    internal class Driver
    {
        public int DriverId { get; set; }
        public string FullName { get; set; }
        public long PhoneNumber { get; set; }
        public Driver(int driverId, string fullName, long phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
}
