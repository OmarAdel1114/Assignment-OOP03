using Assignment_OOP01.Shipments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP01
{
    internal class DeliveryCenter
    {

        private string centerName;
        private Shipment[] shipments = new Shipment[20];
        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= shipments.Length)
                    return null;

                return shipments[index];
            }
            set
            {
                if (index < 0 || index >= shipments.Length)
                    return;

                shipments[index] = value;
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }

        public string CenterName 
        {
            get { return centerName; }
            set { centerName = value;  }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(Shipment shipment) { 
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == shipment)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;   
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                    continue;

                Console.WriteLine($"--- Shipment {i + 1} ---");

                Console.WriteLine($"Tracking Code: {shipments[i].TrackingCode}");
                Console.WriteLine($"Description: {shipments[i].Description}");
                Console.WriteLine($"Weight: {shipments[i].Weight}");
                Console.WriteLine($"Delivery Fee: {shipments[i].DeliveryFee}");
                Console.WriteLine($"Destination: {shipments[i].Destination.City}");

               if (shipments[i] is ExpressShipment express)
                {
                    Console.WriteLine($"Extra Fee: {express.ExtraFee}");
                }
                else if (shipments[i] is InternationalShipment international)
                {
                    Console.WriteLine($"Destination Country: {international.DestinationCountry}");
                    Console.WriteLine($"Customs Fee: {international.CustomsFee}");
                }

                Console.WriteLine();
            }
        }


    }
}
