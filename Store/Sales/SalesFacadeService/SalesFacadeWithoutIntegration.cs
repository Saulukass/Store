using Store.IntegrationServices;
using Store.Sales.SalesDomainEntities;
using Store.Sales.SalesDomainServices;
using Store.Sales.SalesRepository;
using System;

namespace Store.Sales.SalesFacadeService
    {
    public class SalesFacadeWithoutIntegration : ISalesFacade
        {
        ICustomerRepository customers;
        IOrderRepository orders;
        ISalesFactory salesFactory;
        IEmailSender emailSender;
        IOrderPriceCalculator priceCalculator;

        public SalesFacadeWithoutIntegration(ICustomerRepository customers, IOrderRepository orders, ISalesFactory salesFactory,
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

            return orderId;
            }

        public int RegisterCustomer(string name, string surname, string email)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating customer");
            ICustomer newCustomer = salesFactory.CreateCustomer(name, surname, email);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving customer");
            int customerId = customers.Save(newCustomer);

            return customerId;
            }
        }
    }
