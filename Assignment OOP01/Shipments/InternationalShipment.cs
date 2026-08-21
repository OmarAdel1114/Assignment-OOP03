using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP01.Shipments
{
    internal class InternationalShipment :Shipment
    {
        private string destinationCountry;
        private decimal customsFee;
        public InternationalShipment(string destinationCountry,decimal customsFee, string trackingCode, string description, int weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            destinationCountry = destinationCountry;
            customsFee = customsFee;    
        }

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set { if (!string.IsNullOrWhiteSpace(value)) value = destinationCountry;  }
        }

        public decimal CustomsFee { 
            get { return customsFee; } 
            set { if (value >= 0) customsFee = value; }
        }

        public override decimal EstimatedCost { get { return DeliveryFee + (Weight * 5) + CustomsFee; } }

        public override string PrintShipment()
        {
            return $"Tracking Code: {base.TrackingCode}\nDescription: {base.Description}\nWeight: {base.Weight}\nDelivery Fee: " +
                    $"{base.DeliveryFee}\nCustoms Fee: {CustomsFee}\nDestination Country:{DestinationCountry}\nDestination: {base.Destination.GetFullAddress()}\nEstimated Cost: {EstimatedCost}";
        }
        public virtual void GenerateCustomsReport() 
        { }

    }
}
