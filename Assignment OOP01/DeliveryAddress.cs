using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP01
{
    internal struct DeliveryAddress
    {
        private string city;
        private string street;
        private int buildingNumber;

        public DeliveryAddress(string City , string Street , int BuildingNumber)
        {
            city = City;
            street = Street;
            buildingNumber = BuildingNumber;
        }

        public string City
        {
            get { return city; }
            set { 
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Invalid city");
                else
                    city = value;
            }
        }

        public string Street    
        {
            get { return street; }
            set {
                if (string.IsNullOrEmpty(value)|| value.GetType()!= typeof(string))
                    Console.WriteLine("Invalid street");
                else
                    street = value;
            }
        }
                   
        public int BuildingNumber
        {
            get { return buildingNumber; }
            set { buildingNumber = value; }
        }


        public string GetFullAddress()
        {
            return $"City:{city}\nStreet: {street}\nBuilding Number: {buildingNumber}";
        }
    }
}
