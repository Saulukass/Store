using Store.Sales.SalesDomainEntities;
using Store.Sales.SalesDomainServices;
using System;

namespace Store.Sales.SalesFacadeService
    {
    class SalesFacadeImplementation : ISalesFacade
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
            IOrder toDelete = orders.FindOrder(orderId);
            if (null == toDelete)
                return -1;

            ICustomer customer = customers.FindCutomer(toDelete.CustomerId);
            if (null == customer)
                return orderId;

            string message = "Your order was cancelled.";
            emailSender.SendEmail(customer.Email, message);
            return orderId;
            }

        public int PalceOrder(string phoneName, int customerId)
            {
            ICustomer customer = customers.FindCutomer(customerId);
            if (null == customer)
                {
                Console.WriteLine("Customer not found.");
                return -1;
                }

            int price = priceCalculator.CalculatePrice(customer);
            IOrder newOrder = salesFactory.CreateOrder(phoneName, customerId, price);
            int orderId = orders.Save(newOrder);

            string message = "Your order was accepted! Order ID -- " + orderId;
            emailSender.SendEmail(customer.Email, message);
            return orderId;
            }

        public int RegisterCustomer(string name, string surname, string email)
            {
            ICustomer newCustomer = salesFactory.CreateCustomer(name, surname, email);
            int customerId = customers.Save(newCustomer);

            string message = "You have successfully registered to our store! You can start shopping! Your ID -- " + customerId;
            emailSender.SendEmail(newCustomer.Email, message);
            return customerId;
            }
        }
    }
