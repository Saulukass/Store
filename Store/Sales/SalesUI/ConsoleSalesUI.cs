using Store.Sales.SalesController;
using System;

namespace Store.Sales.SalesUI
    {
    public class ConsoleSalesUI : ISalesUI
        {
        ISalesController controller;

        public ConsoleSalesUI(ISalesController controller)
            {
            this.controller = controller;
            }

        public void CancelOrder()
            {
            Console.WriteLine("Enter order id: ");
            int orderId = Int32.Parse(Console.ReadLine());

            int cancelledId = controller.CancelOrder(orderId);
            if (-1 != cancelledId)
                Console.WriteLine("Cancelled order with ID -- " + cancelledId);
            else
                Console.WriteLine("Order with ID -- " + orderId + "  does not exist");
            }

        public void PlaceOrder()
            {
            Console.WriteLine("Enter customer id: ");
            int customerId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter phone name: ");
            string phoneName = Console.ReadLine();

            int orderId = controller.PlaceOrder(phoneName, customerId);
            Console.WriteLine("Order placed with ID -- " + orderId);
            }

        public void RegisterCustomer()
            {
            Console.WriteLine("Enter customer name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter customer surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter customer email: ");
            string email = Console.ReadLine();

            int id = controller.RegisterCustomer(name, surname, email);
            Console.WriteLine("Registered customer with ID -- " + id);
            }
        }
    }
