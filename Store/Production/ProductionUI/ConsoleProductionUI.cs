using Store.Production.ProductionController;
using System;

namespace Store.Production.ProductionUI
    {
    public class ConsoleProductionUI : IProductionUI
        {
        IProductionController controller;

        public ConsoleProductionUI(IProductionController controller)
            {
            this.controller = controller;
            }

        public void AddPhone()
            {
            Console.WriteLine("Enter phone name: ");
            string phoneName = Console.ReadLine();
            Console.WriteLine("Enter warehouse id: ");
            int warehouseId = Int32.Parse(Console.ReadLine());

            int phoneId = controller.AddPhone(phoneName, warehouseId);
            Console.WriteLine("Phone added with ID -- " + phoneId);
            }

        public void GetPhoneQuantity()
            {
            Console.WriteLine("Enter phone id: ");
            int phoneId = Int32.Parse(Console.ReadLine());

            int quantity = controller.GetPhoneQuantity(phoneId);
            Console.WriteLine("Currently we have " + quantity + " phones");
            }

        public void GetTransportationPrice()
            {
            Console.WriteLine("Enter warehouse id: ");
            int warehouseId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter destination: ");
            string location = Console.ReadLine();

            int price = controller.GetTransportationPrice(warehouseId, location);
            Console.WriteLine("Transportation price to this location: " + price);
            }

        public void OpenWarehouse()
            {
            Console.WriteLine("Enter warehouse location: ");
            string location = Console.ReadLine();
            Console.WriteLine("Enter warehouse capacity: ");
            int capacity = Int32.Parse(Console.ReadLine());

            int warehouseId = controller.OpenWarehouse(location, capacity);
            Console.WriteLine("Warehouse opened with ID -- " + warehouseId);
            }
        }
    }
