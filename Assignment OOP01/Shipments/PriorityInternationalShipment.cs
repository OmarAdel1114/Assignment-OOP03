using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP01.Shipments
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string destinationCountry,decimal customsFee, string trackingCode, string description, int weight, decimal deliveryFee, DeliveryAddress destination)
            : base(destinationCountry, customsFee, trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override sealed void GenerateCustomsReport()
        { }
    }
}
