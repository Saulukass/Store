using System;

namespace Store.Sales.SalesDomainEntities
    {
    public class DiscountedSalesFactory : ISalesFactory
        {
        public ICustomer CreateCustomer(string name, string surname, string email)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating loyal customer");
            return new LoyalCustomer(name, surname, email);
            }

        public IOrder CreateOrder(string phoneName, int customerId, int price)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating DiscountedOrder");
            return new DiscountedOrder(phoneName, customerId, price);
            }
        }
    }
