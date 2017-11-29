namespace Store.Sales.SalesDomainEntities
    {
    public class DiscountedSalesFactory : ISalesFactory
        {
        public ICustomer CreateCustomer(string name, string surname, string email)
            {
            return new LoyalCustomer(name, surname, email);
            }

        public IOrder CreateOrder(string phoneName, int customerId, int price)
            {
            return new DiscountedOrder(phoneName, customerId, price);
            }
        }
    }
