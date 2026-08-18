using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP01.Shipments
{
    #region Question 02 Part 02
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, int weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

    }
    #endregion

}
