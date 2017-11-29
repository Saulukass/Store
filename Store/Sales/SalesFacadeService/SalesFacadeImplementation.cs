using Store.Sales.SalesDomainEntities;
using Store.Sales.SalesDomainServices;
using System;

namespace Store.Sales.SalesFacadeService
    {
    public class SalesFacadeImplementation : ISalesFacade
        {
        ICustomerRepository customers;
        IOrderRepository orders;
        ISalesFactory salesFactory;
        IEmailSender emailSender;
        IOrderPriceCalculator priceCalculator;

        public SalesFacadeImplementation(ICustomerRepository customers, IOrderRepository orders, ISalesFactory salesFactory,
            IEmailSender emailSender, IOrderPriceCalculator priceCalculator)
            {
            this.customers = customers;
            this.orders = orders;
            this.salesFactory = salesFactory;
            this.emailSender = emailSender;
            this.priceCalculator = priceCalculator;
            }

        public int CancelOrder(int orderId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for order in repository");
            IOrder toDelete = orders.Find(orderId);
            if (null == toDelete)
                return -1;

            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Order found");
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for customer to notify about order cancelling");
            ICustomer customer = customers.Find(toDelete.CustomerId);
            if (null == customer)
                return orderId;

            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Customer found");
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Sending email");
            string message = "Your order was cancelled.";
            emailSender.SendEmail(customer.Email, message);
            return orderId;
            }

        public int PalceOrder(string phoneName, int customerId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for customer in repository");
            ICustomer customer = customers.Find(customerId);
            if (null == customer)
                {
                Console.WriteLine("Customer not found.");
                return -1;
                }
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Customer found");
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Calculating order price");
            int price = priceCalculator.CalculatePrice(customer);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating order");
            IOrder newOrder = salesFactory.CreateOrder(phoneName, customerId, price);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving order");
            int orderId = orders.Save(newOrder);

            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Sending email to customer");
            string message = "Your order was accepted! Order ID -- " + orderId;
            emailSender.SendEmail(customer.Email, message);
            return orderId;
            }

        public int RegisterCustomer(string name, string surname, string email)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating customer");
            ICustomer newCustomer = salesFactory.CreateCustomer(name, surname, email);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving customer");
            int customerId = customers.Save(newCustomer);

            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Sending email to customer about registration");
            string message = "You have successfully registered to our store! You can start shopping! Your ID -- " + customerId;
            emailSender.SendEmail(newCustomer.Email, message);
            return customerId;
            }
        }
    }
