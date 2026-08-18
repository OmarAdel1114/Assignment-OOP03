using Assignment_OOP01.Shipments;

namespace Assignment_OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Question 01
            /*
             a) The difference between a class and a struct are:
                  - A class is a reference type, while a struct is a value type.
                 - A class can have inheritance, while a struct cannot 
                 - A class can have a default constructor, while a struct cannot have a default constructor.
             */
            /*
             b) Classes are more suitable for large projects because they support inheritance,and they support complex data structures
             */

            #endregion

            #region Question 02
            // a) The parent class is shipment
            // b) The child class is ExpressShipment
            // c) TrackingCode
            // d) Because duplicating the same code multiple time makes the code harder to maintain and increases the risk of bugs and errors


            #endregion
            #endregion

            #region Part 02      
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please Choose Your Shipment Type: \n1) Standard Shipment \n2) Express Shipment \n3) International Shipment");
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the Tracking code for your Standard shipment:");
                            string trackingCode = Console.ReadLine();

                            Console.WriteLine("Enter the Description for your Standard shipment:");
                            string description = Console.ReadLine();

                            Console.WriteLine("Enter the Weight for your Standard shipment:");
                            int.TryParse(Console.ReadLine(), out int weight);

                            Console.WriteLine("Enter the Delivery Fee for your Standard shipment:");
                            decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

                            Console.WriteLine("Enter the Destination for your Standard shipment:");
                            DeliveryAddress destination = new DeliveryAddress();
                            Console.WriteLine("Enter the City for your Standard shipment:");
                            destination.City = Console.ReadLine();
                            Console.WriteLine("Enter the Street for your Standard shipment:");
                            destination.Street = Console.ReadLine();
                            Console.WriteLine("Enter the Building number for your Standard shipment:");
                            int.TryParse(Console.ReadLine(), out int buildingNumber);

                            Shipment standardShipment = new StandardShipment(
                                trackingCode, description, weight, deliveryFee, destination);
                            deliveryCenter.AddShipment(standardShipment);
                            Console.WriteLine("Shipment added Successfully");

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the Extra Fee for your Express shipment:");
                            decimal.TryParse(Console.ReadLine(), out decimal extraFee);
                            Console.WriteLine("Enter the Tracking code for your Express shipment:");
                            string trackingCode = Console.ReadLine();

                            Console.WriteLine("Enter the Description for your Express shipment:");
                            string description = Console.ReadLine();

                            Console.WriteLine("Enter the Weight for your Express shipment:");
                            int.TryParse(Console.ReadLine(), out int weight);

                            Console.WriteLine("Enter the Delivery Fee for your Express shipment:");
                            decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

                            Console.WriteLine("Enter the Destination for your Express shipment:");
                            DeliveryAddress destination = new DeliveryAddress();
                            Console.WriteLine("Enter the City for your Express shipment:");
                            destination.City = Console.ReadLine();
                            Console.WriteLine("Enter the Street for your Express shipment:");
                            destination.Street = Console.ReadLine();
                            Console.WriteLine("Enter the Building number for your Express shipment:");
                            int.TryParse(Console.ReadLine(), out int buildingNumber);

                            Shipment expressShipment = new ExpressShipment(
                                extraFee, trackingCode, description, weight, deliveryFee, destination);
                            deliveryCenter.AddShipment(expressShipment);
                            Console.WriteLine("Shipment added Successfully");
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("Enter the Destination Country for your International shipment:");
                            string destinationCountry = Console.ReadLine();

                            Console.WriteLine("Enter the Customs Fee for your International shipment:");
                            decimal.TryParse(Console.ReadLine(), out decimal customsFee);

                            Console.WriteLine("Enter the Tracking code for your International shipment:");
                            string trackingCode = Console.ReadLine();

                            Console.WriteLine("Enter the Description for your International shipment:");
                            string description = Console.ReadLine();

                            Console.WriteLine("Enter the Weight for your International shipment:");
                            int.TryParse(Console.ReadLine(), out int weight);

                            Console.WriteLine("Enter the Delivery Fee for your International shipment:");
                            decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

                            Console.WriteLine("Enter the Destination for your International shipment:");
                            DeliveryAddress destination = new DeliveryAddress();
                            Console.WriteLine("Enter the City for your International shipment:");
                            destination.City = Console.ReadLine();
                            Console.WriteLine("Enter the Street for your International shipment:");
                            destination.Street = Console.ReadLine();
                            Console.WriteLine("Enter the Building number for your International shipment:");
                            int.TryParse(Console.ReadLine(), out int buildingNumber);

                            Shipment internationalShipment = new InternationalShipment(
                                destinationCountry, customsFee, trackingCode, description, weight, deliveryFee, destination);
                            deliveryCenter.AddShipment(internationalShipment);
                            Console.WriteLine("Shipment added Successfully");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            deliveryCenter.PrintAllShipments();

            Console.Write("Enter Tracking Code to search: ");
            string searchCode = Console.ReadLine();
            Shipment foundShipment = deliveryCenter[searchCode];
            if (foundShipment != null)
            {
                Console.WriteLine("Found:");
                Console.WriteLine($"Tracking Code: {foundShipment.TrackingCode}");
                Console.WriteLine($"Description: {foundShipment.Description}");
                Console.WriteLine($"Weight: {foundShipment.Weight}");
                Console.WriteLine($"Delivery Fee: {foundShipment.DeliveryFee}");
                Console.WriteLine($"Estimated Cost: {foundShipment.EstimatedCost}");
                Console.WriteLine($"Destination: {foundShipment.Destination.City}");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }
            Console.Write("Enter Tracking Code to delete: ");
            string deleteCode = Console.ReadLine();
            bool isDeleted = deliveryCenter.RemoveShipment(deliveryCenter[deleteCode]);

            deliveryCenter.PrintAllShipments();


            #endregion
        }
        }
    }

