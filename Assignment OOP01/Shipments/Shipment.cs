using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Assignment_OOP01.Shipments
{
    internal class Shipment
    {
		
		private string trackingCode;
		private string description;
		private int weight;
		private decimal deliveryFee;
		private DeliveryAddress destination;
		public string TrackingCode
		{
			get { return trackingCode; }
		}
		public string Description

        {
			get { return description; }
			set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("You must Add description");
                else
                    description = value;
            }
		}
		public int Weight
		{
			get { return weight; }
			set { 
				if (value > 0)
					weight = value;
				else
					Console.WriteLine("Weight must greater than zero");
						}
		}
		public decimal DeliveryFee
		{
			get { return deliveryFee; }
			private set {
                if (value > 0)
                    deliveryFee = value;
                else
                    Console.WriteLine("Delivery fee must be greater than zero");
            }
		}
		public DeliveryAddress Destination
		{
			get { return destination; }
			set { value = destination; }
		}
        public decimal EstimatedCost { get {return DeliveryFee + (Weight * 5); } }


     
        public Shipment(string trackingCode)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = trackingCode;
            else
                this.trackingCode = "Unknown";
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            this.destination = new DeliveryAddress();
        }
        public Shipment(string trackingCode, string description, int weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = string.IsNullOrWhiteSpace(trackingCode)? "Unknown": trackingCode;

            Description = string.IsNullOrWhiteSpace(description)? "Unknown": description;

            Weight = weight > 0 ? weight : 1;

            DeliveryFee = deliveryFee > 0 ? deliveryFee : 50;

            this.destination = destination;

        }




        public void UpdateDeliveryFee(decimal newFee) 
        { 
            if (newFee > 0)
                DeliveryFee = (int)newFee;
        }

        public string PrintShipment() { 
        return $"Tracking Code: {trackingCode}\nDescription: {description}\nWeight: {weight}\nDelivery Fee: {deliveryFee}\nDestination: {destination.GetFullAddress()}\nEstimated Cost: {EstimatedCost}";
        }
       
    



    }
}
