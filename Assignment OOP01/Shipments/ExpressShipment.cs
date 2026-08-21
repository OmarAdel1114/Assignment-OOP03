using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP01.Shipments
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;
        public ExpressShipment(decimal extraFee,string trackingCode, string description, int weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            extraFee = extraFee;
        }

        public decimal ExtraFee
        {
            get { return extraFee; }
            set { if (value >= 0) extraFee = value; }
        }

        public override decimal EstimatedCost { get { return DeliveryFee + (Weight * 5) + ExtraFee; } }


        public override string PrintShipment()
        {
            return $"Tracking Code: {base.TrackingCode}\nDescription: {base.Description}\nWeight: {base.Weight}\nDelivery Fee: " +
                    $"{base.DeliveryFee}\nExtra Fee:{ExtraFee}\nDestination: {base.Destination.GetFullAddress()}\nEstimated Cost: {EstimatedCost}";
        }

    }
}
