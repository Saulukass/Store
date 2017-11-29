using System;

namespace Store.Sales.SalesDomainEntities
    {
    public class RegularSalesFactory : ISalesFactory
        {
        public ICustomer CreateCustomer(string name, string surname, string email)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating RegularCustomer");
            return new RegularCustomer(name, surname, email);
            }

        public IOrder CreateOrder(string phoneName, int customerId, int price)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating RegularOrder");
            return new RegularOrder(phoneName, customerId, price);
            }
        }
    }
